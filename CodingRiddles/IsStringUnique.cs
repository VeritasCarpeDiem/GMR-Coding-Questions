using System;
using System.Collections.Generic;
using System.Text;

namespace CodingRiddles
{
    class IsStringUnique
    {
        static public bool isStringUnique(string word) //hash table- key/value pair O(n) time complexity
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

    }
}
