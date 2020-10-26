using System;
using System.Collections.Generic;
using System.Text;

namespace CodingRiddles
{
    class EZ_14
    {
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
    }
}
