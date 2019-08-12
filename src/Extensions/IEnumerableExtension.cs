using System;
using System.Collections.Generic;

namespace MiSe.Shuffle.Extensions
{
    /// <summary>Extension method to shuffle an <see cref="IEnumerable{T}"/>.</summary>
    public static class IEnumerableExtension
    {
        /// <summary>Returns a shuffled array of an <see cref="IEnumerable{T}"/>.</summary>
        /// <typeparam name="T">Type of items in <paramref name="source"/>.</typeparam>
        /// <param name="source">The enumerable to shuffle.</param>
        /// <param name="randomNumberGenerator">The random number generator to use.</param>
        /// <exception cref="ArgumentNullException">If <paramref name="source"/> is null - or <paramref name="randomNumberGenerator"/> is null.</exception>
        public static T[] ShuffleCopy<T>(this IEnumerable<T> source, Random randomNumberGenerator)
            => ShuffleOps.ShuffleCopy(source, randomNumberGenerator);
    }
}
