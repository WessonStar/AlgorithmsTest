using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsRiver.YSort
{
    /// <summary>
    /// 插入排序，在已排序集合中寻找插入位置
    /// </summary>
    class InsertionSort<T> : SortBase<T>, ISorter<T>
        where T : IComparable<T>
    {
        public void Sort(T[] source)
        {
            int size = source.Length;
            for (int i = 1; i < size; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (Less(source[j], source[j - 1]))
                    {
                        Swap(source, j - 1, j);
                    }
                }
            }
        }
    }
}
