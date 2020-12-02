using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsTest.Sort
{
    /// <summary>
    /// 冒泡排序，不断比较相邻的值，通过交换将最大值挪到右侧
    /// </summary>
    class BubbleSort<T> : SortBase<T>, ISorter<T>
        where T : IComparable<T>
    {
        public void Sort(T[] source)
        {
            int size = source.Length;
            for (int i = 0; i < size; i++)
            {
                bool swapped = false;
                
                for (int j = 1; j < size-i; j++)
                {
                    if (Less(source[j], source[j-1]))
                    {
                        Swap(source, j - 1, j);
                        swapped = true;
                    }
                }

                if (!swapped)
                {
                    break;
                }
            }
        }
    }
}
