using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TicTacToe_JHermansen

{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] array = new char[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = ' ';
                }
            }
            DrawBoard(array);
            char result;
            do
            {
                ProccessTurn(array, 'X');
                result = VerifyBoard(array);
                Console.Clear();
                DrawBoard(array);
                if (result == 'X')
                    break;
                ProccessTurn(array, 'O');
                result = VerifyBoard(array);
                Console.Clear();
                DrawBoard(array);
            } while (result == ' ');
            if (result == 'O' || result == 'X')
                Console.WriteLine("\n\n\n" + result + " Has Won!!");
            if (result == ' ')
                Console.WriteLine("\n\n\nNo One Wins");
            Console.ReadLine();
        }
        public static void DrawBoard(char[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("|" + array[i, j] + " ");
                }
                Console.WriteLine("|");
            }
        }
        public static char VerifyBoard(char[,] array)
        {
            if (array[0, 0] == 'X' && array[0, 1] == 'X' && array[0, 2] == 'X')
            { return 'X'; }
            if (array[1, 0] == 'X' && array[1, 1] == 'X' && array[1, 2] == 'X')
            { return 'X'; }
            if (array[2, 0] == 'X' && array[2, 1] == 'X' && array[2, 2] == 'X')
            { return 'X'; }
            if (array[0, 0] == 'X' && array[1, 0] == 'X' && array[2, 0] == 'X')
            { return 'X'; }
            if (array[0, 1] == 'X' && array[1, 1] == 'X' && array[2, 1] == 'X')
            { return 'X'; }
            if (array[0, 2] == 'X' && array[1, 2] == 'X' && array[2, 2] == 'X')
            { return 'X'; }
            if (array[0, 0] == 'X' && array[1, 1] == 'X' && array[2, 2] == 'X')
            { return 'X'; }
            if (array[2, 0] == 'X' && array[1, 1] == 'X' && array[0, 2] == 'X')
            { return 'X'; }
            if (array[0, 0] == 'O' && array[0, 1] == 'O' && array[0, 2] == 'O')
            { return 'O'; }
            if (array[1, 0] == 'O' && array[1, 1] == 'O' && array[1, 2] == 'O')
            { return 'O'; }
            if (array[2, 0] == 'O' && array[2, 1] == 'O' && array[2, 2] == 'O')
            { return 'O'; }
            if (array[0, 0] == 'O' && array[1, 0] == 'O' && array[2, 0] == 'O')
            { return 'O'; }
            if (array[0, 1] == 'O' && array[1, 1] == 'O' && array[2, 1] == 'O')
            { return 'O'; }
            if (array[0, 2] == 'O' && array[1, 2] == 'O' && array[2, 2] == 'O')
            { return 'O'; }
            if (array[0, 0] == 'O' && array[1, 1] == 'O' && array[2, 2] == 'O')
            { return 'O'; }
            if (array[2, 0] == 'O' && array[1, 1] == 'O' && array[0, 2] == 'O')
            { return 'O'; }
            return ' ';
        }
        public static void ProccessTurn(char[,] array, char player)
        {
            do
            {
                Console.WriteLine(player + " it is your turn, choose a coordinate : ");
                Console.Write("X Coordinate: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Y Coordinate: ");
                int y = int.Parse(Console.ReadLine());

                if (array[x, y] == ' ')
                {
                    array[x, y] = player;
                    break;
                }
            } while (true);
        }
    }
}
