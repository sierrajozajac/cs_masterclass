using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace C_Masterclass_Proj
{
    // Section 7 challenge
    class TicTacToe
    {
        /*
          +---+---+---+
          | 0 | 1 | 2 |
          +---+---+---+
          | 3 | 4 | 5 |
          +---+---+---+
          | 6 | 7 | 8 |
          +---+---+---+
         */
        private readonly static string LINE = "+---+---+---+";
        private static string[,] fields = new string[,]
        {
            {"0","1","2"},
            {"3","4","5"},
            {"6","7","8"}
        };
        private static bool isGameOver = false;

        public static void Main(string[] args)
        {
            int currPlayer = 1;
            while(!isGameOver)
            {
                PrintUpdate();
                Console.WriteLine();
                Console.WriteLine("Player #{0}: Please enter your field!", currPlayer);
                string userInput = Console.ReadLine();
                int tmp;
                int val;
                if (int.TryParse(userInput, out tmp))
                {
                    val = tmp;
                    bool success = PlayerSelection(currPlayer, val);
                    if (success)
                    {
                        currPlayer = currPlayer == 1 ? 2 : 1;
                        HasAnyoneWon();
                    }
                    else
                    {
                        Console.WriteLine("Attempt unsuccessful. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
        }

        public static void PrintUpdate()
        {
            Console.WriteLine(LINE);
            for (int i=0; i<3; i++)
            {
                string ret = "| ";
                for (int j=0; j<3; j++)
                {
                    ret += fields[i, j];
                    ret += " | ";
                }
                Console.WriteLine(ret);
                Console.WriteLine(LINE);
            }
        }

        public static bool PlayerSelection(int playerNum, int field)
        {
            bool success = true;
            int locRow;
            int locCol;

            switch (field)
            {
                case 0:
                    locRow = 0;
                    locCol = 0;
                    break;
                case 1:
                    locRow = 0;
                    locCol = 1;
                    break;
                case 2:
                    locRow = 0;
                    locCol = 2;
                    break;
                case 3:
                    locRow = 1;
                    locCol = 0;
                    break;
                case 4:
                    locRow = 1;
                    locCol = 1;
                    break;
                case 5:
                    locRow = 1;
                    locCol = 2;
                    break;
                case 6:
                    locRow = 2;
                    locCol = 0;
                    break;
                case 7:
                    locRow = 2;
                    locCol = 1;
                    break;
                case 8:
                    locRow = 2;
                    locCol = 2;
                    break;
                default:
                    locRow = 0;
                    locCol = 0;
                    break;
            }

            string currFieldValue = fields[locRow, locCol];
            if (currFieldValue.Equals("O") || currFieldValue.Equals("X"))
            {
                success = false;
            }
            else
            {
                string currChar = playerNum == 1 ? "X" : "O";
                fields[locRow, locCol] = currChar;
            }

            return success;
        }

        public static void HasAnyoneWon()
        {
            bool diagonal1 = fields[0, 0].Equals(fields[1, 1]) && fields[0, 0].Equals(fields[2, 2]);
            if (diagonal1)
            {
                string val = fields[0, 0];
                int winner = val.Equals("X") ? 1 : 2;
                CongratilateWinner(winner);
            }

            bool diagonal2 = fields[0, 2].Equals(fields[1, 1]) && fields[0, 2].Equals(fields[2, 0]);
            if (diagonal2)
            {
                string val = fields[0, 2];
                int winner = val.Equals("X") ? 1 : 2;
                CongratilateWinner(winner);
            }

            bool row1 = fields[0, 0].Equals(fields[0, 1]) && fields[0, 0].Equals(fields[0, 2]);
            if (row1)
            {
                string val = fields[0, 0];
                int winner = val.Equals("X") ? 1 : 2;
                CongratilateWinner(winner);
            }

            bool row2 = fields[1, 0].Equals(fields[1, 1]) && fields[1, 0].Equals(fields[1, 2]);
            if (row2)
            {
                string val = fields[1, 0];
                int winner = val.Equals("X") ? 1 : 2;
                CongratilateWinner(winner);
            }

            bool row3 = fields[2, 0].Equals(fields[2, 1]) && fields[2, 0].Equals(fields[2, 2]);
            if (row3)
            {
                string val = fields[2, 0];
                int winner = val.Equals("X") ? 1 : 2;
                CongratilateWinner(winner);

            }

            bool col1 = fields[0, 0].Equals(fields[1, 0]) && fields[0, 0].Equals(fields[2, 0]);
            if (col1)
            {
                string val = fields[0, 0];
                int winner = val.Equals("X") ? 1 : 2;
                CongratilateWinner(winner);
            }

            bool col2 = fields[0, 1].Equals(fields[1, 1]) && fields[0, 1].Equals(fields[2, 1]);
            if (col2)
            {
                string val = fields[0, 1];
                int winner = val.Equals("X") ? 1 : 2;
                CongratilateWinner(winner);
            }

            bool col3 = fields[0, 2].Equals(fields[1, 2]) && fields[0, 2].Equals(fields[2, 2]);
            if (col3)
            {
                string val = fields[0, 2];
                int winner = val.Equals("X") ? 1 : 2;
                CongratilateWinner(winner);
            }
        }

        public static void CongratilateWinner(int winner)
        {
            Console.WriteLine("Congratulations player #{0}! You have won!", winner);
            Console.WriteLine("Would you like to play again? Y/N");
            string userInput = Console.ReadLine();
            if(userInput.Equals("Y") || userInput.Equals("y"))
            {
                Console.WriteLine();
                Reset();
            }
            else
            {
                isGameOver = true;
            }
        }

        public static void Reset()
        {
            int count = 0;
            for (int i=0; i<3; i++)
            {
                for (int j=0; j<3; j++)
                {
                    fields[i, j] = count + "";
                    count++;
                }
            }
        }
    }
}
