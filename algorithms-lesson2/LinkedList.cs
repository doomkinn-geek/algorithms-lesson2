using System;
using System.Collections.Generic;
using System.Text;

namespace algorithms_lesson2
{
    public class LinkedList : ILinkedList
    {
        private Node head;
        private Node tail;
        private int count;

        public LinkedList()
        {
            head = null;
            tail = null;
            count = 0;
        }
        public void AddNode(int value)
        {
            Node node = new Node(value);

            if (head == null)
                head = node;
            else
            {
                tail.NextNode = node;
                node.PrevNode = tail;
            }
            tail = node;
            count++;
        }

        public void AddNodeAfter(Node node, int value)
        {
            Node found = FindNode(node.Value);
            if (found != null)
            {
                Node newNode = new Node(value);
                if (found.NextNode != null)
                {                    
                    newNode.PrevNode = found;
                    newNode.NextNode = found.NextNode;
                    found.NextNode.PrevNode = newNode;
                    found.NextNode = newNode;
                }
                else
                {
                    tail = newNode;
                    found.NextNode = newNode;
                    newNode.PrevNode = found;
                }
                count++;                           
            }
        }

        public Node FindNode(int searchValue)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Value.Equals(searchValue))
                {
                    break;
                }
                current = current.NextNode;
            }            
            return current;            
        }

        public int GetCount()
        {
            return count;
        }

        public void RemoveNode(int index)
        {
            Node found = ValueByIndex(index);
            if(found != null)            
                RemoveNode(found);           
        }

        public Node ValueByIndex(int index)
        {
            Node current = head;
            int currentIndex = 0;

            // поиск удаляемого узла
            while (currentIndex != index)
            {
                currentIndex++;
                current = current.NextNode;
            }
            return current;
        }

        public void RemoveNode(Node node)
        {
            Node found = FindNode(node.Value);
            if (found != null)
            {
                if (found.PrevNode != null)
                    found.PrevNode.NextNode = found.NextNode;
                else
                    head = found.NextNode;
                if (found.NextNode != null)
                    found.NextNode.PrevNode = found.PrevNode;
                else
                    tail = found.PrevNode;
                count--;                 
            }
        }
    }

}
