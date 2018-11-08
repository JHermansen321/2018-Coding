using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int seed = 1234;
            Random rand = new Random(seed);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 9);
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
            // int temp = array[0];
            // array[0] = array[1];
            // array[1] = temp;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] > array[i])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }

                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();


        }

    }
}
