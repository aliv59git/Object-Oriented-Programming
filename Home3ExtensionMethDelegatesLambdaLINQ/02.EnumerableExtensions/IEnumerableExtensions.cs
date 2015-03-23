using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EnumerableExtensions
{
    public static class IEnumerableExt
    {
        public static T SumOfElements<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T sumOfElements = default(T);
            foreach (var item in collection)
            {
                sumOfElements += (dynamic)item;
            }

            return sumOfElements;
        }

        public static T ProductOfElements<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T productOfElements = collection.FirstOrDefault();
            foreach (var item in collection.Skip(1))
            {
                productOfElements *= (dynamic)item;
            }

            return productOfElements;
        }

        public static T MinOfElements<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T minOfElements = collection.FirstOrDefault();
            foreach (var item in collection)
            {
                if (item.CompareTo(minOfElements) < 0)
                {
                    minOfElements = item;
                }
            }

            return minOfElements;
        }

        public static T MaxOfElements<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T maxOfElements = collection.FirstOrDefault();
            foreach (var item in collection)
            {
                if (item.CompareTo(maxOfElements) > 0)
                {
                    maxOfElements = item;
                }
            }

            return maxOfElements;
        }

        public static T AverageOfElements<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T AverageOfElements = collection.FirstOrDefault();
            foreach (var item in collection.Skip(1))
            {
                AverageOfElements += (dynamic)item;
            }

            return (dynamic)AverageOfElements / collection.Count();
        }

    }
}
