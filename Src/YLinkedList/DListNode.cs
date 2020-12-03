using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsRiver.YLinkedList
{
    class DListNode<TKey, TValue>
    {
        public DListNode<TKey, TValue> Pre;

        public DListNode<TKey, TValue> Next;

        public TKey Key;

        public TValue Value;
    }
}
