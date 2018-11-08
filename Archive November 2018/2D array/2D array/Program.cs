using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] multiDimensionalArray = new int[10, 5];
            for (int i = 0; i < multiDimensionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < multiDimensionalArray.GetLength(1); j++)
                {
                    multiDimensionalArray[i, j] = i * j;
                }
            }
            Print2dArray(multiDimensionalArray);         
            
        }
        static void Print2dArray(int[,] x)
        {
            
            {
                for (int i = 0; i < x.GetLength(0); i++)
                {
                    for (int j = 0; j < x.GetLength(1); j++)
                    {
                        Console.Write(x[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

