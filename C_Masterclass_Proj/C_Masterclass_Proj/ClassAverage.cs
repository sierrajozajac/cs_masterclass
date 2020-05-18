using System;
using System.Collections.Generic;
using System.Text;

namespace C_Masterclass_Proj
{
    // Section 5 challenge
    class ClassAverage
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Valid scores are numbers in the range [0-20]");
            Console.WriteLine("Enter -1 to quit.");
            bool continueBool = true;
            double sum = 0;
            double cnt = 0;

            do
            {
                Console.WriteLine("Please enter a valid score.");
                string userInput = Console.ReadLine();

                double tmp;
                if (double.TryParse(userInput, out tmp))
                {
                    if (tmp == -1)
                    {
                        continueBool = false;
                    }
                    else if (tmp < 0 || tmp > 20)
                    {
                        Console.WriteLine("Invalid score. Please try again.");
                    }
                    else
                    {
                        cnt++;
                        sum += tmp;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid score. Please try again.");
                }
            } while (continueBool);

            Console.WriteLine();
            Console.WriteLine("You have chosen to quit.");

            double avg = sum / cnt;
            Console.WriteLine("Class average: " + avg);
        }
    }
}
