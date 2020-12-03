using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsRiver
{
    interface ISorter<T> where T : IComparable<T>
    {
        void Sort(T[] source);
    }
}
