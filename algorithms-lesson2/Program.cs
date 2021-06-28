using System;

namespace algorithms_lesson2
{
    class Program
    {
        private static LinkedList lList;
        static void Main(string[] args)
        {
            lList = new LinkedList();
            lList.AddNode(3);
            lList.AddNode(55);
            lList.AddNode(33);
            lList.AddNodeAfter(new Node(55), 22);
            Console.WriteLine("Первоначальный список");
            PrintLinkedList();

            lList.FindNode(33);
            lList.RemoveNode(3);
            Console.WriteLine("Удалили элемент с индексом 3");
            PrintLinkedList();

            lList.AddNode(11);
            lList.AddNodeAfter(new Node(3), 5);
            Console.WriteLine("Добавили элемент в хвост и новый после '3'");
            PrintLinkedList();            
        }
        static void PrintLinkedList()
        {
            for (int i = 0; i < lList.GetCount(); i++)
            {
                if (lList.ValueByIndex(i) != null)
                    Console.WriteLine("Элемент связанного списка # {0} - {1}", i, lList.ValueByIndex(i).Value);
            }
        }
    }
}
