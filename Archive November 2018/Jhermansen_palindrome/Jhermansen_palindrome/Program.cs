using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jhermansen_palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("palindrome checker v1");
            Console.WriteLine();
            Console.WriteLine("*----------------------*");
            Console.WriteLine("Enter a word or sentece:");
            string G = Console.ReadLine();
            StringBuilder j = new StringBuilder();
            for (int i = G.Length - 1; i >= 0; i--)
            {
                j.Append(G[i]);
            }
            string compstrng = j.ToString();
            Console.WriteLine(compstrng);
            {
                if (G == compstrng)
                {
                    Console.WriteLine(G + " is a palindrome");
                }
                else
                {
                    Console.WriteLine(G + " is not a palindrome");
                }
            }
        }
    }
}




