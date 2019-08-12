using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BenchmarkDotNet.Attributes;

namespace MiSe.Shuffle.Benchmarks
{
    [ClrJob(baseline: true), CoreJob]
    [RPlotExporter, RankColumn]
    public class Benchmark1
    {
        private List<int> data;

        [Params(1000, 10000)]
        public int N;

        [GlobalSetup]
        public void Setup()
        {
            data = Enumerable.Range(0, N).ToList();
        }

        [Benchmark(Baseline = true)]
        public int Option1()
        {
            return 1;
        }

        [Benchmark]
        public int Option2()
        {
            return 2;
        }
    }
}
