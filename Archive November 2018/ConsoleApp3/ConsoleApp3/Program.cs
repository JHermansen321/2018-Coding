using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] myIntArray = new int[10];
            myIntArray[0] = r.Next();
            myIntArray[1] = r.Next();
            myIntArray[2] = r.Next();
            myIntArray[3] = r.Next();
            for (int i = 0; i < myIntArray.Length; i++)
            {
                myIntArray[i] = r.Next();
            }
            List<int> myIntList = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                myIntList.Add(i);
                Console.WriteLine(myIntArray[i]);

            }
        }
    }
}