using System;

namespace TicTacToe_JHermansen
{
    class Program
    {
        static char[] Box = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;  
        static int choice;
        static int Value = 0;
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Player 1: X and Player 2: O");
                Console.WriteLine("\n");
                if (player % 2 == 0)
                {
                    Console.WriteLine("Player 2's Turn");
                }
                else
                {
                    Console.WriteLine("Player 1's Turn");
                }
                Console.WriteLine("\n");
                Board();
                choice = int.Parse(Console.ReadLine());     
                if (Box[choice] != 'X' && Box[choice] != 'O')
                {
                    if (player % 2 == 0) 
                    {
                        Box[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        Box[choice] = 'X';
                        player++;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry box {0} is already marked with {1}", choice, Box[choice]);
                }
                Value = CheckWin();
            } while (Value != 1 && Value != -1);

            Console.Clear();
            Board(); 
            if (Value == 1)
            {
                Console.WriteLine("Player {0} has won", (player % 2) + 1);
            }
            else
            {
                Console.WriteLine("Draw");
            }
            Console.ReadLine();
        }  
        private static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", Box[1], Box[2], Box[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", Box[4], Box[5], Box[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", Box[7], Box[8], Box[9]);
            Console.WriteLine("     |     |      ");
        }
        private static int CheckWin()
        {
            #region Horzontal Winning Condtion 
            if (Box[1] == Box[2] && Box[2] == Box[3])
            {
                return 1;
            }
            else if (Box[4] == Box[5] && Box[5] == Box[6])
            {
                return 1;
            }
            else if (Box[6] == Box[7] && Box[7] == Box[8])
            {
                return 1;
            }
            #endregion
            #region vertical Winning Condtion     
            else if (Box[1] == Box[4] && Box[4] == Box[7])
            {
                return 1;
            }
            else if (Box[2] == Box[5] && Box[5] == Box[8])
            {
                return 1;
            }
            else if (Box[3] == Box[6] && Box[6] == Box[9])
            {
                return 1;
            }
            #endregion
            #region Diagonal Winning Condition
            else if (Box[1] == Box[5] && Box[5] == Box[9])
            {
                return 1;
            }
            else if (Box[3] == Box[5] && Box[5] == Box[7])
            {
                return 1;
            }
            #endregion
            #region Checking For Draw
            else if (Box[1] != '1' && Box[2] != '2' && Box[3] != '3' && Box[4] != '4' && Box[5] != '5' && Box[6] != '6' && Box[7] != '7' && Box[8] != '8' && Box[9] != '9')
            {
                return -1;
            }
            #endregion
            else
            {
                return 0;
            }
        }
    }
}