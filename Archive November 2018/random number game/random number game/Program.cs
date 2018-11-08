using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random_number_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int Randomnumber = random.Next(1, 1000);
            int G = 0;
            int N = 0;
            Console.WriteLine("input your number guess between 1-1000");
            while (G != Randomnumber)
            {

                G = int.Parse(Console.ReadLine());
                N++;
                if (G < Randomnumber)

                {
                    Console.WriteLine("No, the number is greater than " + G + " Guess again");
                }

                else if (G > Randomnumber)
                {
                    Console.WriteLine("The number is less than " + G + " guess again");
                }
            }
            Console.WriteLine("Good job the answer was " + Randomnumber + " it took you " + N + " tries");
            Console.ReadLine();
        }
    }
}
//new random object 
//creates a random number 
//make the random number between a certain range of numbers
//create an array that stores your guesses in the array
//do while tests your guess of number choice until gets correct 
//create realine store in int
//if statement telling if correct then readline correct and exit 
//else statement telling if not correct then writeline incorrect 
//if statment telling user input less than or greater than 
//create writleine saying random number < > input of int
//create readline saying random number < > input of int