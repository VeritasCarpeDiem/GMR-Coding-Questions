using System;
using System.Collections.Generic;
using System.Text;

namespace CodingRiddles
{
    public class DS_10
    {
        public class SimpleTree
        {
            public int Value { get; set; }
            public SimpleTree Left { get; set; }
            public SimpleTree Right { get; set; }

            public static SimpleTree Root { get; set; }
            public SimpleTree MakeTreeRecursively(int[] numbers, int low, int high) //binary search 
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

                root.Left = MakeTreeRecursively(numbers, low, mid - 1);
                root.Right = MakeTreeRecursively(numbers, mid + 1, high);

                return root;
            }

            static public int MakeTreetIteratively(int[] arr, int num)
            {
                int low = 0;
                int high = arr.Length - 1;

                while (low <= high)
                {
                    int mid = (low + high) / 2; //arr={1,2,3,4,5} num=5

                    if (num == arr[mid])
                    {
                        return arr[mid];
                    }
                    if (num > arr[mid])
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
            public List<int> PreOrder()
            {
                List<int> ReturnPath = new List<int>();
                SimpleTree current = Root;

                HelperPreOrder(ReturnPath, current);

                return ReturnPath;
                void HelperPreOrder(List<int> ReturnPath, SimpleTree current)
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
        }
    }
}
