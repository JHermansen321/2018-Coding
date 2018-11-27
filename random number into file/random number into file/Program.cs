using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace random_number_into_file
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] MyReadArray = new int[10];
            int Answer = 0;
            while (Answer != 4)
            {
                Console.WriteLine("........................................................................................");
                Console.WriteLine(".. Enter the integer value for the action you want to preform");
                Console.WriteLine(".. 1. Save a random array to file ");
                Console.WriteLine(".. 2. Load a random array from a file");
                Console.WriteLine(".. 3. Print array from a file");
                Console.WriteLine(".. 4. Exit");
                Console.WriteLine("........................................................................................");
                string path = "example.txt";
                Answer = int.Parse(Console.ReadLine());
                if (Answer == 1)
                {
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        Random r = new Random();
                        int[] myIntArray = new int[10];
                        for (int i = 0; i < myIntArray.Length; i++)
                        {
                            myIntArray[i] = r.Next();
                        }
                        for (int i = 0; i < 10; i++)
                        {
                            sw.WriteLine(myIntArray[i]);
                        }
                    }
                }
                if (Answer == 2)               
                {                    
                    using (StreamReader sr = new StreamReader(path))
                    {
                        int result;
                        for (int i = 0; i < MyReadArray.Length; i++)
                        {
                            result = int.Parse(sr.ReadLine());
                            MyReadArray[i] = result;
                        }
                    }
                   
                }
                if (Answer == 3)
                {
                    for (int i = 0; i < MyReadArray.Length; i++)
                    {
                        Console.WriteLine(MyReadArray[i]);
                    }
                }
                if (Answer == 4)
                    return;
                
            }
               
        }
    }
}
