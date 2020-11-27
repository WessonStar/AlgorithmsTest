using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsTest.Sort
{
    /// <summary>
    /// 插入排序，在已排序集合中寻找插入位置
    /// </summary>
    class InsertionSort<T> : SortBase<T>, ISort<T>
        where T : IComparable<T>
    {
        public void Sort(T[] source)
        {
            int size = source.Length;
            for (int i = 1; i < size; i++)
            {
                for (int j = i; Less(source[j], source[j-1]) && j > 0; j--)
                {
                    Exchange(source, i - 1, i);
                }
            }
        }
    }
}
