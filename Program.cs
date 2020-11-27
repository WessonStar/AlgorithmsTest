using System;
using AlgorithmsTest.Sort;

namespace AlgorithmsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var source = new int[] { 2, 3, 6, 4, 5, 7, 6 };

            //ISort<int> sorter = new BubbleSort<int>();
            //ISort<int> sorter = new InsertionSort<int>();
            //ISort<int> sorter = new SelectionSort<int>();
            //ISort<int> sorter = new QuickSort<int>();
            ISort<int> sorter = new MergeSort<int>();
            
            sorter.Sort(source);

            Console.WriteLine(String.Join(",", source));
        }
    }
}
