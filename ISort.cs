using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsTest
{
    interface ISort<T> where T : IComparable<T>
    {
        void Sort(T[] source);
    }
}
