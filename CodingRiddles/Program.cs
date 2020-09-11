using System;
using System.Collections.Generic;

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


        static void Main(string[] args)
        {
            //PrintTriangle();

            // int number = ParseInt("420"); //int.Parse(userInput);

            //Console.WriteLine(number);

            Console.WriteLine(IsStringUnique("Jin"));
        }
    }
}
