using System;
using System.Collections.Generic;
using System.Linq;

namespace MiSe.Shuffle
{
    /// <summary>Contains shuffle methods.</summary>
    public static class ShuffleOps
    {
        /// <summary>Shuffles a <see cref="IList{T}"/>.</summary>
        /// <typeparam name="T">Type of items in <paramref name="list"/>.</typeparam>
        /// <param name="list">The list to shuffle.</param>
        /// <param name="randomNumberGenerator">The random number generator to use.</param>
        /// <exception cref="ArgumentNullException">If <paramref name="list"/> is null - or <paramref name="randomNumberGenerator"/> is null.</exception>
        public static void ShuffleInPlace<T>(IList<T> list, Random randomNumberGenerator)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list));
            }
            if (randomNumberGenerator == null)
            {
                throw new ArgumentNullException(nameof(randomNumberGenerator));
            }
            var remaining = list.Count;
            while (remaining > 0)
            {
                var randomIndex = randomNumberGenerator.Next(remaining);
                remaining--;
                (list[remaining], list[randomIndex]) = (list[randomIndex], list[remaining]);
            }
        }

        /// <summary>Returns a shuffled copy of an <see cref="IEnumerable{T}"/>.</summary>
        /// <typeparam name="T">Type of items in <paramref name="enumerable"/>.</typeparam>
        /// <param name="enumerable">The enumerable to shuffle.</param>
        /// <param name="randomNumberGenerator">The random number generator to use.</param>
        /// <exception cref="ArgumentNullException">If <paramref name="enumerable"/> is null - or <paramref name="randomNumberGenerator"/> is null.</exception>
        public static T[] ShuffleCopy<T>(IEnumerable<T> enumerable, Random randomNumberGenerator)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }
            var array = enumerable.ToArray();
            ShuffleInPlace(array, randomNumberGenerator);
            return array;
        }
    }
}
