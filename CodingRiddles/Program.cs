using System;

namespace CodingRiddles
{
    class Program
    {
        static void Main(string[] args)
        {
            //DS-14:
            //https://www.geeksforgeeks.org/nested-classes-in-c-sharp/
            
            DS_14<int>.LinkedList<int> list = new DS_14<int>.LinkedList<int>();

            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);

            list.DisplayList(); //1->2->3->null

            list.ReverseLinkedList(ref list.Head);
            Console.WriteLine();
            list.DisplayList(); //3->2->1->null

            //DS-10:
            int[] integers = { 1, 2, 3, 4, 5 };

            DS_10.SimpleTree BST = new DS_10.SimpleTree();

            BST.MakeTreeRecursively(integers, 0, integers.Length - 1);

            var ReturnPath = BST.PreOrder();

            foreach (var item in ReturnPath)
            {
                Console.Write($"{item}->");

            }

        }

    }

}

