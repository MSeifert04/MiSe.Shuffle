using System;
using System.Collections.Generic;

namespace MiSe.Shuffle.Extensions
{
    /// <summary>Extension method to shuffle an <see cref="IList{T}"/>.</summary>
    public static class RandomExtension
    {
        /// <summary>Shuffles a <see cref="IList{T}"/>.</summary>
        /// <typeparam name="T">Type of items in <paramref name="list"/>.</typeparam>
        /// <param name="source">The random number generator to use.</param>
        /// <param name="list">The list to shuffle.</param>
        /// <exception cref="ArgumentNullException">If <paramref name="list"/> is null - or <paramref name="source"/> is null.</exception>
        public static void Shuffle<T>(this Random source, IList<T> list)
            => ShuffleOps.ShuffleInPlace(list, source);
    }
}
