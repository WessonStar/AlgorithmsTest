using System;
using AlgorithmsTest.Sort;
using AlgorithmsTest.Queue;

namespace AlgorithmsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            TestCircularQueue();
        }

        static void TestSort()
        {
            var source = new int[] { 2, 3, 6, 4, 5, 7, 6 };

            //ISort<int> sorter = new BubbleSort<int>();
            //ISort<int> sorter = new InsertionSort<int>();
            //ISort<int> sorter = new SelectionSort<int>();
            //ISort<int> sorter = new QuickSort<int>();
            ISorter<int> sorter = new MergeSort<int>();
            sorter.Sort(source);

            Console.WriteLine(String.Join(",", source));
        }

        static void TestCircularQueue()
        {
            var queue = new CircularQueue<int>(2);
            queue.Enqueue(10);
            queue.Enqueue(9);
            Console.WriteLine(queue.Dequeue());
            queue.Enqueue(7);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
        }
    }
}
