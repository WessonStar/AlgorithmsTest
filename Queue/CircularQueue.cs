using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsTest.Queue
{
    class CircularQueue<TItem>
        where TItem : IEquatable<TItem>
    {
        public CircularQueue() : this(10) {}

        public CircularQueue(int capacity)
        {
            this.queue = new TItem[capacity];
        }

        private readonly TItem[] queue;

        private int head = 0;

        private int tail = 0;

        public int Count { get; private set; } = 0;

        public void Enqueue(TItem item)
        {
            if (this.Count == this.queue.Length)
            {
                throw new OverflowException();
            }

            this.queue[tail] = item;
            this.tail = (this.tail + 1) % this.queue.Length;
            this.Count++;
        }

        public TItem Dequeue()
        {
            if (this.Count == 0)
            {
                throw new OverflowException();
            }

            var item = this.queue[head];
            this.head = (this.head + 1) % this.queue.Length;
            this.Count--;

            return item;
        }
    }
}
