using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    class Program
    {
        //EZ-14:
        static public int ParseInt(string input)
        {
            int digit = 0;
            //int total = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char character = input[i];

                if (character >= '0' && character <= '9')
                {
                    // This is a digit - let's see which one!

                    digit = digit * 10 + (character - '0');
                   
                }
            }
            //total = digit;
            return digit;
        }
        //EZ-15:
        static public void PrintTriangle()
        {
            int SizeOfBase = int.Parse(Console.ReadLine());

            if (SizeOfBase >= 3 && SizeOfBase <= 9 && SizeOfBase % 2 != 0)
            {
                for (int i = 0; i <= SizeOfBase; i++)
                {
                    for (int j = 1; j < i + 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }

        static public bool IsStringUnique(string word) //hash table- key/value pair O(n) time complexity
        {
            //string is array of chars
            const int AsciiValues = 256;
            bool[] chars = new bool[AsciiValues];

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = false;
            }
            for (int i = 0; i < word.Length; i++)
            {
                int AsciiValue = word[i] - '0';

                if (chars[AsciiValue] == true)
                {
                    return false;
                }
                chars[AsciiValue] = true;
            }
            return true;
        }

        public class Node
        {

            public Node Left { get; set; }
            public Node Right { get; set; }


        }
        static public int MakeTreetIteratively(int []arr, int num)
        {
            int low = 0;
            int high = arr.Length - 1;
            
            while(low <= high)
            {
                int mid = (low + high) / 2; //arr={1,2,3,4,5} num=5

                if(num ==arr[mid])
                {
                    return arr[mid];
                }
                if(num>arr[mid])
                {
                    low = mid + 1;
                }
                else //num<arr[mid]
                {
                    high = mid - 1;
                }
            }
            return -1;
        }
        class SimpleTree
        {

            public int Value { get; set; }
            public SimpleTree Left { get; set; }
            public SimpleTree Right { get; set; }

            public static SimpleTree Root { get; set; }
            public static SimpleTree MakeTreeRecursively(int[] numbers, int low, int high) //binary search 
            {
                //Inorder traversal for sorted array
                //int low = 0;
                //int high = numbers.Length - 1;

                if (low > high) //base case
                {
                    return null;
                }
                int mid = (low + high) / 2;//truncates the 0.5 if even # of elements in array

                SimpleTree root = new SimpleTree() { Value = numbers[mid] };//set Root equal to mid element of array

                root.Left = MakeTreeRecursively(numbers,low, mid-1);
                root.Right = MakeTreeRecursively(numbers, mid+1, high);


                return root;

            }
  
            public static List<int> PreOrder()
            {
                List<int> ReturnPath = new List<int>();
                SimpleTree current = Root;

                HelperPreOrder(ReturnPath, current);
                
                return ReturnPath;
                void HelperPreOrder(List<int> ReturnPath,SimpleTree current)
                {
                    ReturnPath.Add(current.Value);
                    if (current.Left != null)
                    {
                        HelperPreOrder(ReturnPath, current.Left);
                    }
                    if (current.Right != null)
                    {
                        HelperPreOrder(ReturnPath, current.Right);
                    }
                }

               
            }
            static void Main(string[] args)
            {
                int[] integers = { 1, 2,3,4,5};

                SimpleTree BST = new SimpleTree();

                 MakeTreeRecursively(integers,0,integers.Length-1);

                var ReturnPath= PreOrder();

                foreach (var item in ReturnPath)
                {
                    Console.Write($"{item}->");

                }




            }

        }
        
    }
}
