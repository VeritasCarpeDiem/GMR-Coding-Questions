using System;
using System.Collections.Generic;
using System.Text;

namespace CodingRiddles
{
    class EZ_15
    {
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
    }
}
