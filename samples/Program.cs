using System;
using System.Collections.Generic;

using MiSe.Shuffle;
using MiSe.Shuffle.Extensions;

namespace MiSe.Shuffle.Samples
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Example1();
            Example2();
            Example3();
            Example4();
        }

        private static void Example1()
        {
            var rng = new Random(Seed: 5);
            var a = new List<int> { 1, 2, 3, 4, 5, 6 };
            ShuffleOps.ShuffleInPlace(a, rng);
            Console.WriteLine(string.Join(", ", a));
        }

        private static void Example2()
        {
            var rng = new Random(Seed: 5);
            var a = new List<int> { 1, 2, 3, 4, 5, 6 };
            var b = ShuffleOps.ShuffleCopy(a, rng);
            Console.WriteLine(string.Join(", ", b));
        }

        private static void Example3()
        {
            var rng = new Random(Seed: 5);
            var a = new List<int> { 1, 2, 3, 4, 5, 6 };
            rng.Shuffle(a);
            Console.WriteLine(string.Join(", ", a));
        }

        private static void Example4()
        {
            var rng = new Random(Seed: 5);
            var a = new List<int> { 1, 2, 3, 4, 5, 6 };
            var b = a.ShuffleCopy(rng);
            Console.WriteLine(string.Join(", ", b));
        }
    }
}
