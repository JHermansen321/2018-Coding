using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> L = new List<int>();
            Random R = new Random();
            int[] J = new int[100];
            for (int i = 1; i <= 100; i++)
            {
                J[i-1] = R.Next();
                Console.WriteLine(J[i-1]);



                L.Add(i);
                Console.WriteLine(L[i-1]);
            }

        }

    }
}
