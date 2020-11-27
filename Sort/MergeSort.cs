using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsTest.Sort
{
    /// <summary>
    /// 归并排序，需要额外的空间
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class MergeSort<T> : SortBase<T>, ISort<T>
        where T : IComparable<T>
    {
        public void Sort(T[] source)
        {
            Sort(source, 0, source.Length - 1, new T[source.Length]);
        }

        private void Sort(T[] source, int lo, int hi, T[] tmp)
        {
            if (lo >= hi) return;

            int mid = (hi + lo) / 2;
            Sort(source, lo, mid, tmp);
            Sort(source, mid + 1, hi, tmp);
            Merge(source, lo, mid, hi, tmp);
        }

        private void Merge(T[] source, int lo, int mid, int hi, T[] tmp)
        {
            //[lo...mid] [mid+1...hi]
            int i = lo, j = mid + 1;

            for (int k = lo; k <= hi; k++)
            {
                if (i > mid) tmp[k] = source[j++];
                else if (j > hi) tmp[k] = source[i++];
                else if (Less(source[i], source[j])) tmp[k] = source[i++];
                else tmp[k] = source[j++];
            }

            for (int k = lo; k <= hi; k++)
            {
                source[k] = tmp[k];
            }
        }
    }
}
