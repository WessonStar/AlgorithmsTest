using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsTest.Sort
{
    class SortBase<T> where T : IComparable<T>
    {
        protected void Exchange(T[] source, int l, int r)
        {
            T tmp = source[l];
            source[l] = source[r];
            source[r] = tmp;
        }

        protected bool Less(T left, T right)
        {
            return left.CompareTo(right) < 0;
        }
    }
}
