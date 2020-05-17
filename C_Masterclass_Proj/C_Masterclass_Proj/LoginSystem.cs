using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace C_Masterclass_Proj
{
    // Section 4 exercise 1
    // Create a log in system
    class LoginSystem
    {
        private static User[] users = new User[10];
        private static int usersCnt = 0;

        public static void Main(string[] args)
        {
            // Create a user login system
            bool programContinues = true;
            Console.WriteLine("Welcome!");

            while (programContinues)
            {
                Console.WriteLine("To register, enter 0.");
                Console.WriteLine("To login, enter 1.");
                Console.WriteLine("To quit, enter 2.");

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
                        RegisterUser();
                        break;
                    case 1:
                        LoginUser();
                        break;
                    case 2:
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

        public static void RegisterUser()
        {
            Console.WriteLine("Enter your username.");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter your password.");
            string password = Console.ReadLine();
            Console.WriteLine("Are you an admin? Y/N");
            string adminInput = Console.ReadLine();
            bool isAdmin;
            if (adminInput.Equals("Y"))
            {
                isAdmin = true;
            }
            else if (adminInput.Equals("N"))
            {
                isAdmin = false;
            }
            else
            {
                Console.WriteLine("Invalid input. Assumed you are not an admin.");
                isAdmin = false;
            }

            User newUser = new User(userName, password, isAdmin);
            bool isDuplicate = false;

            for (int i = 0; i < usersCnt; i++)
            {
                User tmp = users[i];
                if (tmp.Equals(newUser))
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (!isDuplicate)
            {
                usersCnt++;
                users[usersCnt - 1] = newUser;
                Console.WriteLine("You have successfully registered!");
            }
            else
            {
                Console.WriteLine("You have tried to input a duplicate profile.");
            }
        }

        public static void LoginUser()
        {
            Console.WriteLine("Enter your username.");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter your password.");
            string password = Console.ReadLine();

            User curr;

            for (int i = 0; i < usersCnt; i++)
            {
                User tmp = users[i];
                bool sameUser = userName.Equals(tmp.getUserName());
                bool samePass = password.Equals(tmp.getPassword());

                if (sameUser && samePass)
                {
                    curr = tmp;
                    WelcomeUser(curr);
                    break;
                }
            }
        }

        public static void WelcomeUser(User currentUser)
        {
            if (currentUser.getUserName() != "")
            {
                if (currentUser.isAdmin())
                {
                    Console.WriteLine("Hi there, Admin {0}!", currentUser.getUserName());
                }
                else
                {
                    Console.WriteLine("Hi there, {0}!", currentUser.getUserName());
                }
            }
            else
            {
                Console.WriteLine("Hi there, registered user!");
            }
        }
    }
}
