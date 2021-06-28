using System;
using System.Collections.Generic;
using System.Text;

namespace algorithms_lesson2
{
    public class LinkedList : ILinkedList
    {
        private Node head;
        private Node tail;
        private uint count;

        public LinkedList()
        {
            head = null;
            tail = null;
            count = 0;
        }
        public void AddNode(int value)
        {
            throw new NotImplementedException();
        }

        public void AddNodeAfter(Node node, int value)
        {
            FindNode(node.Value).NextNode.Value = value;
        }

        public Node FindNode(int searchValue)
        {
            throw new NotImplementedException();
        }

        public int GetCount()
        {
            return (int)count;
        }

        public void RemoveNode(int index)
        {
            var (before, target) = FindWithBeforeNode(value);

            if (target == null)
            {
                return;
            }

            _tail = target.Next == null ? before : _tail;

            if (before == null)
            {
                _head = target.Next;

                return true;
            }

            before.Next = target.Next;            
        }

        public void RemoveNode(Node node)
        {
            throw new NotImplementedException();
        }
    }

}
