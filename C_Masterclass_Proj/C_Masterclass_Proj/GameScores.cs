using System;
using System.Collections.Generic;
using System.Text;

namespace C_Masterclass_Proj
{
    // Section 4 challenge 2
    class GameScores
    {
        private static int highscore = 0;
        private static string highscorePlayer;

        public static void Main(string[] args)
        {
            Console.WriteLine("Current highscore = 0");
            Console.WriteLine("Current highscore acheiving player = NULL");

            bool programContinues = true;

            while (programContinues)
            {
                Console.WriteLine();
                Console.WriteLine("To enter a new score, enter 0.");
                Console.WriteLine("To quit, enter 1.");

                string userInput = Console.ReadLine();
                int tmp;
                int num;

                if (int.TryParse(userInput, out tmp))
                {
                    num = tmp;
                }
                else
                {
                    num = -1;
                    Console.WriteLine("Invalid entry. Please try again.");
                }

                switch (num)
                {
                    case 0:
                        AddNewScore();
                        break;
                    case 1:
                        programContinues = false;
                        break;
                    case -1:
                        // Invalid entry
                        break;
                    default:
                        break;
                }
            }
        }

        public static void AddNewScore()
        {
            bool userHasInputtedValidScore = false;
            int score = 0;

            while (!userHasInputtedValidScore)
            {
                Console.WriteLine("Enter new score:");
                string scoreInput = Console.ReadLine();

                int tmp;

                if (int.TryParse(scoreInput, out tmp))
                {
                    score = tmp;
                    userHasInputtedValidScore = true;
                }
                else
                {
                    Console.WriteLine("Invalid entry. Please enter an integer.");
                }
            }

            Console.WriteLine("Enter player name:");
            string player = Console.ReadLine();

            if (score > highscore)
            {
                highscorePlayer = player;
                highscore = score;
                Console.WriteLine();
                Console.WriteLine("New highscore is {0}", highscore);
                Console.WriteLine("New highscore holder is {0}", highscorePlayer);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("The old highscore of {0} could not be broken by {1}'s lastest attempt. {2} still holds the highscore.", highscore, player, highscorePlayer);
            }
        }
    }
}
