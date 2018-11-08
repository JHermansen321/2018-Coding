using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Jagged_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[10][];
            for (int i = 0; i < jaggedArray.GetLength(0); i++)
            {
                jaggedArray[i] = new int[i + 1];
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    jaggedArray[i][j] = i * j;
                }
            }
            Print2dJaggedArray(jaggedArray);
        }    
        static void Print2dJaggedArray(int[][] x)
        {
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 1; j < x[i].Length; j++)
                {
                    Console.Write("| " + x[i] [j] + "|");
                }
                Console.WriteLine(" ");
            }
        }
    }
    
}
