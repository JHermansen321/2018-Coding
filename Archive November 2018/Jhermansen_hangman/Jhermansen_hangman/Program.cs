using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Jhermansen_hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hangman V.1");
            Console.WriteLine("You have 6 guesses");
            {
                bool correct = true;
                char guess;
                int numguess = 6;
                Random rand = new Random();
                string[] Array = new string[20];
                Array[0] = "abrupt";
                Array[1] = "snobbish";
                Array[2] = "prevent";
                Array[3] = "expand";
                Array[4] = "hill";
                Array[5] = "sturdy";
                Array[6] = "roof";
                Array[7] = "discover";
                Array[8] = "ragged";
                Array[9] = "strange";
                Array[10] = "scientific";
                Array[11] = "rotten";
                Array[12] = "playing ";
                Array[13] = "built ";
                Array[14] = "popular";
                Array[15] = "students";
                Array[16] = "jump";
                Array[17] = "option";
                Array[18] = "million";
                Array[19] = "trimmed";


                string V = "";

                V = Array[rand.Next(0, 20)];
                List<char> gs = new List<char>();
                do
                {
                    correct = true;
                    for (int i = 0; i < V.Length; i++)
                    {
                        if (gs.Contains(V[i]))
                        {
                            Console.Write(V[i]);
                        }
                        else
                        {
                            Console.Write("_");
                            correct = false;
                        }
                    }
                    if (correct == false)
                        Console.WriteLine();
                    Console.WriteLine("-" + numguess + " guesses left.");
                    Console.Write("guesses characters: ");
                    for (int i = 0; i < gs.Count(); i++)
                    {
                        Console.Write(gs[i]);
                    }
                    Console.WriteLine();
                    Console.WriteLine();                 

                    Console.WriteLine("guess: ");
                    guess = char.Parse(Console.ReadLine());
                    gs.Add(guess);
                    if (!V.Contains(guess))
                    {
                        numguess--;
                    }
                } while (numguess > 0 && correct == false);


            }
        }
    }
    
}
