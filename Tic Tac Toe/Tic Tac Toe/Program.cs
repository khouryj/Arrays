using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Program
    {
        static String[,] board = new String[4, 4];
        static String currentP = "X";
        static String input = "";
        static bool gameOver = false;
        static String validL = "ABCabc";
        static String validN = "123";
        static bool valid = true;
        static int moveR = 0;
        static int moveC = 0;

        static void Main(string[] args)
        {
            reset();
            while (!gameOver)
            {
                update();
            }
        }

        static void reset()
        {
            board[0, 0] = " ";
            board[0, 1] = "  A ";
            board[0, 2] = " B ";
            board[0, 3] = " C ";
            board[1, 0] = "1 ";
            board[2, 0] = "2 ";
            board[3, 0] = "3 ";

            for (int i = 1; i < board.GetLength(0); i++)
            {
                for (int j = 1; j < board.GetLength(1); j++)
                {
                    board[i, j] = " _ ";
                }
            }
        }

        static void update()
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j]);
                    if (j == 3)
                    {
                        Console.Write("\n");
                    }
                }
            }
            Console.Write("Player " + currentP + ", where do you want to move? ");
            input = Console.ReadLine();
            if (!validN.Contains(input[0]) || !validL.Contains(input[1]))
            {
                valid = false;
                while (!valid)
                {
                    Console.Write("\n\nPlease enter a valid move. ");
                    input = Console.ReadLine();
                    if (!validN.Contains(input[0]) || !validL.Contains(input[1]))
                    {
                        valid = false;
                    }
                    else
                    {
                        valid = true;
                    }
                }
            }
            moveR = Convert.ToInt32(input[0].ToString());
            if (input[1] == 'A' || input[1] == 'a')
            {
                moveC = 1;
            }
            else if (input[1] == 'B' || input[1] == 'b')
            {
                moveC = 2;
            }
            else
            {
                moveC = 3;
            }

            if (board[moveR, moveC] != " _ ")
            {
                valid = false;
                while (!valid)
                {
                    Console.Write("\n\nPlease enter a valid move. ");
                    input = Console.ReadLine();

                    moveR = Convert.ToInt32(input[0].ToString());
                    if (input[1] == 'A' || input[1] == 'a')
                    {
                        moveC = 1;
                    }
                    else if (input[1] == 'B' || input[1] == 'b')
                    {
                        moveC = 2;
                    }
                    else
                    {
                        moveC = 3;
                    }
                    if (board[moveR, moveC] != " _ ")
                    {
                        valid = false;
                    }
                    else
                    {
                        valid = true;
                    }
                }
            }
            board[moveR, moveC] = " " + currentP + " ";
            if (currentP == "X")
            {
                currentP = "O";
            }
            else
            {
                currentP = "X";
            }
        }
    }
}
