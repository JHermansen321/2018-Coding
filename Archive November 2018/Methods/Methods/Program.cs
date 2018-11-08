using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void XY(int X, int Y )
        {
            for (int i = 0; i < Y; i++)
            {

                for (int j = 0; j < X; j++)
                {

                    Console.Write("x");
                }
                Console.WriteLine("");
            }            
        }
        
        static void Main(string[] args) { 
        
            int x;
            Console.WriteLine("input x value");
            x = int.Parse(Console.ReadLine());
            int y;
            Console.WriteLine("input y value");
            y = int.Parse(Console.ReadLine());
            XY(x, y);
        }
        
    }
}
