using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            int Answer = 0;
            while (Answer != 10)
            {

                Console.WriteLine("................................................................................................................");
                Console.WriteLine(".. Enter the integer value for the action you want to preform");
                Console.WriteLine(".. 1. Draw small square");
                Console.WriteLine(".. 2. Draw medium square");
                Console.WriteLine(".. 3. Draw big quare");
                Console.WriteLine(".. 4. Draw left triangle");
                Console.WriteLine(".. 5. Draw right triangle");
                Console.WriteLine(".. 6. Draw triangle");
                Console.WriteLine(".. 7. Draw double left triagle");
                Console.WriteLine(".. 8. Draw double left triangle");
                Console.WriteLine(".. 9. Draw Special X");
                Console.WriteLine(".. 10. Exit menu");
                Console.WriteLine("................................................................................................................");


                //Small Square              
                Answer = int.Parse(Console.ReadLine());
                if (Answer == 1)
                    Console.WriteLine("X");
                Console.WriteLine();


                //meduim Square
                if (Answer == 2)
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                Console.WriteLine();


                //big Square
                if (Answer == 3)
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                Console.WriteLine();


                //Leftward Triangle
                if (Answer == 4)
                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                Console.WriteLine();


                //Rightward triangle
                if (Answer == 5)
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (3 - j >= i)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                Console.WriteLine();


                //triangle               
                int m = 3 / 2 + 1;
                for (int i = 0; i < 3; i++)
                    if (Answer == 6)
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            if (j >= m - i && j <= m + i)
                                Console.Write("X");
                            else
                                Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                Console.WriteLine();


                //Left double triangle
                if (Answer == 7)
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (j == i)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                Console.WriteLine();


                //Right double triangle
                if (Answer == 8)
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (4 - j == i)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                Console.WriteLine();


                //Random X
                if (Answer == 9)
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (4 - j == i || j == i)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                Console.WriteLine();
            }
            if (Answer == 10)
                return;
        }
    }
}