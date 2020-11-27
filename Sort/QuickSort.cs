using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsTest.Sort
{
    /// <summary>
    /// 快速排序，定基准+拆分+递归
    /// </summary>
    class QuickSort<T> : SortBase<T>, ISort<T>
        where T : IComparable<T>
    {
        public void Sort(T[] source)
        {
            Sort(source, 0, source.Length - 1);
        }

        private void Sort(T[] source, int lo, int hi)
        {
            if (hi <= lo) return;

            int i = lo + 1, j = hi;
            T key = source[lo];
            while (true)
            {
                while (Less(key, source[j]))
                {
                    j--;
                    if (j == lo)
                    {
                        break;
                    }
                }

                while (Less(source[i], key))
                {
                    i++;
                    if (i == hi)
                    {
                        break;
                    }
                }

                if (i >= j)
                {
                    break;
                }

                Exchange(source, j, i);
            }
            Exchange(source, j, lo);

            Sort(source, lo, j - 1);
            Sort(source, j + 1, hi);
        }
    }
}
