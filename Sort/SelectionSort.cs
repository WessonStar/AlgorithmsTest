using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsTest.Sort
{
    /// <summary>
    /// 选择排序，每次循环找出最小的值，然后与当前值做交换
    /// </summary>
    class SelectionSort<T> : SortBase<T>, ISorter<T> 
        where T : IComparable<T>
    {
        public void Sort(T[] source)
        {
            int size = source.Length;
            for (int i=0; i<size-1; i++)
            {
                int min = i;

                for (int j=i+1; j<size; j++)
                {
                    if (Less(source[j], source[min]))
                    {
                        min = j;
                    }
                }
                
                if (min != i)
                {
                    Swap(source, i, min);
                }
            }
        }
    }
}
