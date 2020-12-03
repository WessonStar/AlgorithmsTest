using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsRiver.YLinkedList
{
    class LRU<TKey, TValue>
    {
        private Dictionary<TKey, DListNode<TKey, TValue>> index;

        private DListNode<TKey, TValue> head, tail;

        private readonly int capacity;

        public void Set(TKey key, TValue value)
        {
            if (index.ContainsKey(key))
            {
                MoveToHead(index[key]);
            }

            if (index.Count == capacity)
            {
                RemoveTail();
            }

            var node = InsetToHead(value);
            index[key] = node;
        }

        public TValue Get(TKey key)
        {
            index.TryGetValue(key, out var node);

            if (node == null)
            {
                throw new KeyNotFoundException();
            }

            this.MoveToHead(node);

            return node.Value;
        }

        private void MoveToHead(DListNode<TKey, TValue> node)
        {
            if (node == head) return;

            node.Pre.Next = node.Next;
            if (node == tail)
            {
                tail = node.Pre;
            }
            else
            {
                node.Next.Pre = node.Pre;
            }

            node.Pre = null;
            node.Next = head;

            head.Pre = node;

            head = node;
        }

        private DListNode<TKey, TValue> InsetToHead(TValue value)
        {
            var node = new DListNode<TKey, TValue>() { Value = value };

            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                node.Next = head;
                head.Pre = node;
                head = node;
            }
            
            return node;
        }

        private void RemoveTail()
        {
            if (tail == null) return;

            index.Remove(tail.Key);

            if (head == tail)
            {
                head = tail = null;

                return;
            }

            tail.Pre.Next = null;
            tail = tail.Pre;
        }
    }
}
