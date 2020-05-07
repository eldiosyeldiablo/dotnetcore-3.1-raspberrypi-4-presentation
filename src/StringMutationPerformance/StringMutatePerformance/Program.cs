using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Running;
using System;
using System.Text;

namespace StringMutatePerformance
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<StringFormatRunner>();
            Console.WriteLine(summary);
        }
    }

    public abstract class BaseData
    {
        public static string DataNumber = 10.ToString();
        public static string Data1 = Guid.NewGuid().ToString();
        public static string Data2 = Guid.NewGuid().ToString();
        public static string Data3 = Guid.NewGuid().ToString();
        public static string Data4 = Guid.NewGuid().ToString();
        public static string Data5 = Guid.NewGuid().ToString();
        public static string Data6 = Guid.NewGuid().ToString();
        public static string Data7 = Guid.NewGuid().ToString();
        public static string Data8 = Guid.NewGuid().ToString();
        public static string Data9 = Guid.NewGuid().ToString();
        public static string Data10 = Guid.NewGuid().ToString();
    }

    public abstract class BaseDataSomeNumbers : BaseData
    {
        public static new int DataNumber = 123456;
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
    public class StringFormatRunner
    {
        [Params(1, 2, 3, 4, 5, 6, 7, 8, 9, 10)]
        public int CountToAppend { get; set; }

        public StringBuilderWorker _stringBuilderWorker;
        public StringContatination _stringConcatWorker;
        public StringContatinationSomeStrings _stringConcatSomeStringsWorker;
        public StringFormat _stringFormatWorker;
        public StringInterpolationAllStrings _stringInterpolationWorker;
        public StringInterpolationSomeStrings _stringInterpolationSomeStringsWorker;

        [GlobalSetup]
        public void Setup()
        {
            _stringBuilderWorker = new StringBuilderWorker();
            _stringConcatWorker = new StringContatination();
            _stringConcatSomeStringsWorker = new StringContatinationSomeStrings();
            _stringFormatWorker = new StringFormat();
            _stringInterpolationWorker = new StringInterpolationAllStrings();
            _stringInterpolationSomeStringsWorker = new StringInterpolationSomeStrings();
        }

        [Benchmark(Baseline = true)]
        public string StringConcatPattern() => _stringConcatWorker.DoIt(CountToAppend);

        [Benchmark]
        public string StringConcatPatternSomeStrings() => _stringConcatWorker.DoIt(CountToAppend);

        [Benchmark]
        public string StringBuilderPattern() => _stringBuilderWorker.DoIt(CountToAppend);

        [Benchmark]
        public string StringFormatPattern() => _stringFormatWorker.DoIt(CountToAppend);

        [Benchmark]
        public string StringInterpolationPatternAllStrings() => _stringInterpolationWorker.DoIt(CountToAppend);

        [Benchmark]
        public string StringInterpolationPatternSomeStrings() => _stringInterpolationSomeStringsWorker.DoIt(CountToAppend);
    }

    public class StringBuilderWorker : BaseData
    {
        public string DoIt(int countToAppend)
        {
            switch (countToAppend)
            {
                case 1:
                    return new StringBuilder().AppendFormat("{0}, you have been here {1} pretend times", Data1, DataNumber).ToString();
                case 2:
                    return new StringBuilder().AppendFormat("{0}{1}, you have been here {2} pretend times", Data1, Data2, DataNumber).ToString();
                case 3:
                    return new StringBuilder().AppendFormat("{0}{1}{2}, you have been here {3} pretend times", Data1, Data2, Data3, DataNumber).ToString();
                case 4:
                    return new StringBuilder().AppendFormat("{0}{1}{2}{3}, you have been here {4} pretend times", Data1, Data2, Data3, Data4, DataNumber).ToString();
                case 5:
                    return new StringBuilder().AppendFormat("{0}{1}{2}{3}{4}, you have been here {5} pretend times", Data1, Data2, Data3, Data4, Data5, DataNumber).ToString();
                case 6:
                    return new StringBuilder().AppendFormat("{0}{1}{2}{3}{4}{5}, you have been here {6} pretend times", Data1, Data2, Data3, Data4, Data5, Data6, DataNumber).ToString();
                case 7:
                    return new StringBuilder().AppendFormat("{0}{1}{2}{3}{4}{5}{6}, you have been here {7} pretend times", Data1, Data2, Data3, Data4, Data5, Data6, Data7, DataNumber).ToString();
                case 8:
                    return new StringBuilder().AppendFormat("{0}{1}{2}{3}{4}{5}{6}{7}, you have been here {8} pretend times", Data1, Data2, Data3, Data4, Data5, Data6, Data7, Data8, DataNumber).ToString();
                case 9:
                    return new StringBuilder().AppendFormat("{0}{1}{2}{3}{4}{5}{6}{7}{8}, you have been here {9} pretend times", Data1, Data2, Data3, Data4, Data5, Data6, Data7, Data8, Data9, DataNumber).ToString();
                case 10:
                    return new StringBuilder().AppendFormat("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}, you have been here {10} pretend times", Data1, Data2, Data3, Data4, Data5, Data6, Data7, Data8, Data9, Data10, DataNumber).ToString();
                default:
                    throw new ArgumentOutOfRangeException(nameof(countToAppend), countToAppend.ToString());
            }
        }
    }

    public class StringContatination : BaseData
    {
        public string DoIt(int countToAppend)
        {
            switch (countToAppend)
            {
                case 1:
                    return Data1 + ", you have been here " + DataNumber + " pretend times";
                case 2:
                    return Data1 + Data2 + ", you have been here " + DataNumber + " pretend times";
                case 3:
                    return Data1 + Data2 + Data3 + ", you have been here " + DataNumber + " pretend times";
                case 4:
                    return Data1 + Data2 + Data3 + Data4 + ", you have been here " + DataNumber + " pretend times";
                case 5:
                    return Data1 + Data2 + Data3 + Data4 + Data5 + ", you have been here " + DataNumber + " pretend times";
                case 6:
                    return Data1 + Data2 + Data3 + Data4 + Data5 + Data6 + ", you have been here " + DataNumber + " pretend times";
                case 7:
                    return Data1 + Data2 + Data3 + Data4 + Data5 + Data6 + Data7 + ", you have been here " + DataNumber + " pretend times";
                case 8:
                    return Data1 + Data2 + Data3 + Data4 + Data5 + Data6 + Data7 + Data8 + ", you have been here " + DataNumber + " pretend times";
                case 9:
                    return Data1 + Data2 + Data3 + Data4 + Data5 + Data6 + Data7 + Data8 + Data9 + ", you have been here " + DataNumber + " pretend times";
                case 10:
                    return Data1 + Data2 + Data3 + Data4 + Data5 + Data6 + Data7 + Data8 + Data9 + Data10 + ", you have been here " + DataNumber + " pretend times";
                default:
                    throw new ArgumentOutOfRangeException(nameof(countToAppend), countToAppend.ToString());
            }
        }
    }
    public class StringContatinationSomeStrings : BaseDataSomeNumbers
    {
        public string DoIt(int countToAppend)
        {
            switch (countToAppend)
            {
                case 1:
                    return Data1 + ", you have been here " + DataNumber + " pretend times";
                case 2:
                    return Data1 + Data2 + ", you have been here " + DataNumber + " pretend times";
                case 3:
                    return Data1 + Data2 + Data3 + ", you have been here " + DataNumber + " pretend times";
                case 4:
                    return Data1 + Data2 + Data3 + Data4 + ", you have been here " + DataNumber + " pretend times";
                case 5:
                    return Data1 + Data2 + Data3 + Data4 + Data5 + ", you have been here " + DataNumber + " pretend times";
                case 6:
                    return Data1 + Data2 + Data3 + Data4 + Data5 + Data6 + ", you have been here " + DataNumber + " pretend times";
                case 7:
                    return Data1 + Data2 + Data3 + Data4 + Data5 + Data6 + Data7 + ", you have been here " + DataNumber + " pretend times";
                case 8:
                    return Data1 + Data2 + Data3 + Data4 + Data5 + Data6 + Data7 + Data8 + ", you have been here " + DataNumber + " pretend times";
                case 9:
                    return Data1 + Data2 + Data3 + Data4 + Data5 + Data6 + Data7 + Data8 + Data9 + ", you have been here " + DataNumber + " pretend times";
                case 10:
                    return Data1 + Data2 + Data3 + Data4 + Data5 + Data6 + Data7 + Data8 + Data9 + Data10 + ", you have been here " + DataNumber + " pretend times";
                default:
                    throw new ArgumentOutOfRangeException(nameof(countToAppend), countToAppend.ToString());
            }
        }
    }

    public class StringFormat : BaseData
    {
        public string DoIt(int countToAppend)
        {
            switch(countToAppend)
            {
                case 1:
                    return string.Format("{0}, you have been here {1} pretend times", Data1, DataNumber);
                case 2:
                    return string.Format("{0}{1}, you have been here {2} pretend times", Data1, Data2, DataNumber);
                case 3:
                    return string.Format("{0}{1}{2}, you have been here {3} pretend times", Data1, Data2, Data3, DataNumber);
                case 4:
                    return string.Format("{0}{1}{2}{3}, you have been here {4} pretend times", Data1, Data2, Data3, Data4, DataNumber);
                case 5:
                    return string.Format("{0}{1}{2}{3}{4}, you have been here {5} pretend times", Data1, Data2, Data3, Data4, Data5, DataNumber);
                case 6:
                    return string.Format("{0}{1}{2}{3}{4}{5}, you have been here {6} pretend times", Data1, Data2, Data3, Data4, Data5, Data6, DataNumber);
                case 7:
                    return string.Format("{0}{1}{2}{3}{4}{5}{6}, you have been here {7} pretend times", Data1, Data2, Data3, Data4, Data5, Data6, Data7, DataNumber);
                case 8:
                    return string.Format("{0}{1}{2}{3}{4}{5}{6}{7}, you have been here {8} pretend times", Data1, Data2, Data3, Data4, Data5, Data6, Data7, Data8, DataNumber);
                case 9:
                    return string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}, you have been here {9} pretend times", Data1, Data2, Data3, Data4, Data5, Data6, Data7, Data8, Data9, DataNumber);
                case 10:
                    return string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}, you have been here {10} pretend times", Data1, Data2, Data3, Data4, Data5, Data6, Data7, Data8, Data9, Data10, DataNumber);
                default:
                    throw new ArgumentOutOfRangeException(nameof(countToAppend), countToAppend.ToString());
            }
        }
    }

    public class StringInterpolationAllStrings : BaseData
    {
        public string DoIt(int countToAppend)
        {
            switch (countToAppend)
            {
                case 1:
                    return $"{Data1}, you have been here {DataNumber} pretend times";
                case 2:
                    return $"{Data1}{Data2}, you have been here {DataNumber} pretend times";
                case 3:
                    return $"{Data1}{Data2}{Data3}, you have been here {DataNumber} pretend times";
                case 4:
                    return $"{Data1}{Data2}{Data3}{Data4}, you have been here {DataNumber} pretend times";
                case 5:
                    return $"{Data1}{Data2}{Data3}{Data4}{Data5}, you have been here {DataNumber} pretend times";
                case 6:
                    return $"{Data1}{Data2}{Data3}{Data4}{Data5}{Data6}, you have been here {DataNumber} pretend times";
                case 7:
                    return $"{Data1}{Data2}{Data3}{Data4}{Data5}{Data6}{Data7}, you have been here {DataNumber} pretend times";
                case 8:
                    return $"{Data1}{Data2}{Data3}{Data4}{Data5}{Data6}{Data7}{Data8}, you have been here {DataNumber} pretend times";
                case 9:
                    return $"{Data1}{Data2}{Data3}{Data4}{Data5}{Data6}{Data7}{Data8}{Data9}, you have been here {DataNumber} pretend times";
                case 10:
                    return $"{Data1}{Data2}{Data3}{Data4}{Data5}{Data6}{Data7}{Data8}{Data9}{Data10}, you have been here {DataNumber} pretend times";
                default:
                    throw new ArgumentOutOfRangeException(nameof(countToAppend), countToAppend.ToString());
            }
        }
    }

    public class StringInterpolationSomeStrings : BaseDataSomeNumbers
    {
        public string DoIt(int countToAppend)
        {
            switch (countToAppend)
            {
                case 1:
                    return $"{Data1}, you have been here {DataNumber} pretend times";
                case 2:
                    return $"{Data1}{Data2}, you have been here {DataNumber} pretend times";
                case 3:
                    return $"{Data1}{Data2}{Data3}, you have been here {DataNumber} pretend times";
                case 4:
                    return $"{Data1}{Data2}{Data3}{Data4}, you have been here {DataNumber} pretend times";
                case 5:
                    return $"{Data1}{Data2}{Data3}{Data4}{Data5}, you have been here {DataNumber} pretend times";
                case 6:
                    return $"{Data1}{Data2}{Data3}{Data4}{Data5}{Data6}, you have been here {DataNumber} pretend times";
                case 7:
                    return $"{Data1}{Data2}{Data3}{Data4}{Data5}{Data6}{Data7}, you have been here {DataNumber} pretend times";
                case 8:
                    return $"{Data1}{Data2}{Data3}{Data4}{Data5}{Data6}{Data7}{Data8}, you have been here {DataNumber} pretend times";
                case 9:
                    return $"{Data1}{Data2}{Data3}{Data4}{Data5}{Data6}{Data7}{Data8}{Data9}, you have been here {DataNumber} pretend times";
                case 10:
                    return $"{Data1}{Data2}{Data3}{Data4}{Data5}{Data6}{Data7}{Data8}{Data9}{Data10}, you have been here {DataNumber} pretend times";
                default:
                    throw new ArgumentOutOfRangeException(nameof(countToAppend), countToAppend.ToString());
            }
        }
    }
}
