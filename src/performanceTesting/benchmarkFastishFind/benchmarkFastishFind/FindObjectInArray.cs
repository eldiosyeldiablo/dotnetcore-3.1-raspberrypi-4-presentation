using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace benchmarkFastishFind
{
    public class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [MemoryDiagnoser] // Analyse the memory usage
    [Orderer(SummaryOrderPolicy.FastestToSlowest, MethodOrderPolicy.Declared)]
    [AsciiDocExporter]
    [CsvExporter]
    [CsvMeasurementsExporter]
    [HtmlExporter]
    [MarkdownExporterAttribute.Default]
    [MarkdownExporterAttribute.GitHub]
    [PlainExporter]
    //[RPlotExporter]
    public class FindObjectInArray
    {
        private Person[] _people;
        private readonly int _listSize = 100;
        //private readonly int _listSize = 1000000;

        public int ListSize { get { return _listSize; } }

        public FindObjectInArray()
        { }

        [GlobalSetup]
        public void PopulatePeopleList()
        {
            var tmp = new List<Person>();
            for (int i = 1; i <= _listSize; i++)
            {
                tmp.Add(new Person()
                {
                    Id = i.ToString(),
                    Name = $"Person{i}"
                });
            }

            _people = tmp.ToArray();
        }

        public IEnumerable<string> DataToFind()
        {
            //int increment = _listSize / 5;

            //List<string> dataToSearch = new List<string>()
            //{
            //    "Person1",
            //};

            //for (int i = 1; i < _listSize; i += increment)
            //{
            //    dataToSearch.Add("Person" + i);
            //}

            //dataToSearch.Add("Person" + _listSize);

            //return dataToSearch;

            //yield return "Person1";

            int increment = _listSize / 3;

            for (int i = 9; i < _listSize; i += increment)
            {
                yield return "Person" + i;
            }

            yield return "Person" + _listSize;
        }

        [Benchmark]
        [ArgumentsSource(nameof(DataToFind))]
        public Person FindWithForLoop(string find)
        {
            for (int i = 1; i <= _listSize; i++)
            {
                Person person = _people[i];
                if (person.Name == find)
                {
                    return person;
                }
            }

            return null;
        }

        [Benchmark]
        [ArgumentsSource(nameof(DataToFind))]

        public Person FindWithForEachLoop(string find)
        {
            foreach (var person in _people)
            {
                if (person.Name == find)
                {
                    return person;
                }
            }

            return null;
        }

        [Benchmark]
        [ArgumentsSource(nameof(DataToFind))]
        public Person FindWithParallelFor(string find)
        {
            Person found = null;
            Parallel.ForEach(_people, (person, state) =>
            {
                if (person.Name == find)
                {
                    found = person;
                    state.Break();
                }
            });

            return found;
        }

        [Benchmark]
        [ArgumentsSource(nameof(DataToFind))]
        public Person FindWithLinqFirstOrDefault(string find) => _people.FirstOrDefault(p => p.Name == find);

        [Benchmark]
        [ArgumentsSource(nameof(DataToFind))]
        public Person FindWithLinqFind(string find) => _people.ToList().Find(p => p.Name == find);

        [Benchmark]
        [ArgumentsSource(nameof(DataToFind))]
        public Person FindByManualParallelTasksByProcessorCount(string find)
        {
            int processorCount = Environment.ProcessorCount;
            int howmanyBranches = processorCount;
            return FindByManualParallelTasksByBranchCountTarget(find, howmanyBranches);
        }

        [Benchmark]
        [ArgumentsSource(nameof(DataToFind))]
        public Person FindByManualParallelTasksBy20Count(string find)
        {
            int howmanyBranches = 20;
            return FindByManualParallelTasksByBranchCountTarget(find, howmanyBranches);
        }

        [Benchmark]
        [ArgumentsSource(nameof(DataToFind))]
        public Person FindByManualParallelTasksBy50Count(string find)
        {
            int howmanyBranches = 50;
            return FindByManualParallelTasksByBranchCountTarget(find, howmanyBranches);
        }

        [Benchmark]
        [ArgumentsSource(nameof(DataToFind))]
        public Person FindByManualParallelTasksBy100Count(string find)
        {
            int howmanyBranches = 100;
            return FindByManualParallelTasksByBranchCountTarget(find, howmanyBranches);
        }

        [Benchmark]
        [ArgumentsSource(nameof(DataToFind))]
        public Person FindByManualParallelTasksBy200Count(string find)
        {
            int howmanyBranches = 200;
            return FindByManualParallelTasksByBranchCountTarget(find, howmanyBranches);
        }

        private Person FindByManualParallelTasksByBranchCountTarget(string find, int howManyBranches)
        {
            Person res = null;
            int branchLength = _listSize / howManyBranches;
            int leftOver = _listSize % howManyBranches;

            var tokenSource = new CancellationTokenSource();
            var token = tokenSource.Token;

            List<Task<Person>> searchingTasksList = new List<Task<Person>>(howManyBranches);
            int start = 0;
            for (int i = 1; i <= howManyBranches; i++)
            {
                int end = i * branchLength;
                if (end > _listSize)
                    end = _listSize;
                end--;

                Range r = new Range(start, end + 1);

                var task = FindInArrary(find, _people[r]);
                searchingTasksList.Add(task);

                start += branchLength;
            }

            if (leftOver > 0)
            {
                Range r = new Range(start, start + leftOver - 1);

                var task = FindInArrary(find, _people[r]);
                searchingTasksList.Add(task);
            }

            bool found = false;

            while (found == false && searchingTasksList.Count > 0)
            {
                var searchingTasks = searchingTasksList.ToArray();
                int index = Task.WaitAny(searchingTasks, token);

                foreach (var task in searchingTasks.Where(x => x.IsCompleted))
                {
                    if (task.IsCompleted == false || task.IsCanceled)
                        continue;

                    if (task.Result != null)
                    {
                        res = task.Result;
                        found = true;

                        tokenSource.Cancel();

                        break;
                    }

                    searchingTasksList.Remove(task);
                }

                if (found)
                {
                    break;
                }
            }

            return res;
        }


        private Task<Person> FindInArrary(string find, Person[] arrayToSearch)
        {
            foreach (var person in arrayToSearch)
            {
                if (person.Name == find)
                {
                    return Task.FromResult(person);
                }
            }

            return Task.FromResult<Person>(null);
        }

        private Task<Person> FindInArraryWithParallelForEach(string find, Person[] arrayToSearch, CancellationToken cts)
        {
            Person found = null;

            ParallelOptions parallelOptions = new ParallelOptions()
            {
                CancellationToken = cts
            };

            Parallel.ForEach(arrayToSearch, parallelOptions, (person, state) =>
            {
                if (person.Name == find)
                {
                    found = person;
                    state.Break();
                }
            });

            return Task.FromResult(found);
        }
    }
}