using System;
using System.Collections.Generic;

using Xunit;

using MiSe.Shuffle.Extensions;

namespace MiSe.Shuffle.Tests
{
    public class ShuffleInplace
    {
        [Fact]
        public void ReadmeExampleWorks()
        {
            var rng = new Random(Seed: 5);
            var a = new List<int> { 1, 2, 3, 4, 5, 6 };
            ShuffleOps.ShuffleInPlace(a, rng);
            Assert.Equal(new[] { 6, 1, 4, 5, 2, 3 }, a);
        }

        [Fact]
        public void FailsWhenFirstArgIsNull()
        {
            var rng = new Random();
            IList<int> a = null;
            Assert.Throws<ArgumentNullException>(() => ShuffleOps.ShuffleInPlace(a, rng));
        }

        [Fact]
        public void FailsWhenSecondArgIsNull()
        {
            Random rng = null;
            var a = new List<int> { 1, 2, 3, 4, 5, 6 };
            Assert.Throws<ArgumentNullException>(() => ShuffleOps.ShuffleInPlace(a, rng));
        }

        [Fact]
        public void ExtensionMethodWorks()
        {
            var rng = new Random(Seed: 5);
            var a = new List<int> { 1, 2, 3, 4, 5, 6 };
            rng.Shuffle(a);
            Assert.Equal(new[] { 6, 1, 4, 5, 2, 3 }, a);
        }
    }
}
