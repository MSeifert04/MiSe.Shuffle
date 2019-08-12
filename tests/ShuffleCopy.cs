using System;
using System.Collections.Generic;

using Xunit;

using MiSe.Shuffle.Extensions;

namespace MiSe.Shuffle.Tests
{
    public class ShuffleCopy
    {
        [Fact]
        public void FailsWhenFirstArgIsNull()
        {
            var rng = new Random();
            IEnumerable<int> a = null;
            Assert.Throws<ArgumentNullException>(() => ShuffleOps.ShuffleCopy(a, rng));
        }

        [Fact]
        public void FailsWhenSecondArgIsNull()
        {
            Random rng = null;
            var a = new List<int> { 1, 2, 3 };
            Assert.Throws<ArgumentNullException>(() => ShuffleOps.ShuffleCopy(a, rng));
        }

        [Fact]
        public void Works()
        {
            var rng = new Random(Seed: 5);
            var a = new List<int> { 1, 2, 3, 4, 5, 6 };
            var b = ShuffleOps.ShuffleCopy(a, rng);
            Assert.Equal(new[] { 6, 1, 4, 5, 2, 3 }, b);
        }

        [Fact]
        public void ExtensionMethodWorks()
        {
            var rng = new Random(Seed: 5);
            var a = new List<int> { 1, 2, 3, 4, 5, 6 };
            var b = a.ShuffleCopy(rng);
            Assert.Equal(new[] { 6, 1, 4, 5, 2, 3 }, b);
        }
    }
}
