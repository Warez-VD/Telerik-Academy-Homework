namespace ExtensionMethods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableEx
    {
        public static decimal MySum<T>(this IEnumerable<T> collection) where T : IConvertible
        {
            var newCollection = collection
                .Select(x => Convert.ToDecimal(x))
                .Sum();

            return newCollection;
        }

        public static decimal MyProduct<T>(this IEnumerable<T> collection) 
            where T : IConvertible
        {
            var newCollection = collection
                .Select(x => Convert.ToDecimal(x));

            decimal product = 1;

            foreach (var item in newCollection)
            {
                product *= item;
            }

            return product;
        }

        public static decimal MyMin<T>(this IEnumerable<T> collection)
        {
            var newCollection = collection
                .Select(x => Convert.ToDecimal(x))
                .Min();

            return newCollection;
        }

        public static decimal MyMax<T>(this IEnumerable<T> collection)
        {
            var newCollection = collection
                .Select(x => Convert.ToDecimal(x))
                .Max();

            return newCollection;
        }

        public static decimal MyAverage<T>(this IEnumerable<T> collection)
        {
            var newCollection = collection
                .Select(x => Convert.ToDecimal(x))
                .Average();

            return newCollection;
        }
    }
}
