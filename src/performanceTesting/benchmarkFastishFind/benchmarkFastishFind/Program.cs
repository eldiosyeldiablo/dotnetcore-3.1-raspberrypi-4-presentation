using BenchmarkDotNet;
using BenchmarkDotNet.Running;
using System;

namespace benchmarkFastishFind
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<FindObjectInArray>();

            Console.WriteLine(summary);

            //FindObjectInArray finder = new FindObjectInArray();
            //finder.PopulatePeopleList();
            //Person p = finder.FindByTreeBruteForce("Person500");

            //bool failed = false;
            //if (p == null)
            //    failed = true;
            //else
            //    failed = false;
        }
    }
}
