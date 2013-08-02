using System;
using System.Collections.Generic;

namespace ThirteenDaysAWeek.AutoMapper4Mvc
{
    internal static class IEnumerableExtensions
    {
        internal static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            foreach (var t in enumerable)
            {
                action(t);
            }
        }
    }
}
