using System;
using System.Reflection.Metadata;
using System.Text.Json;
using System.Threading;

namespace C_Masterclass_Proj
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    //Section1Exercises();
        //    //Section2Exercises();
        //    //Section2Challenge();
        //    //Section3Exercises();
        //    //Section3Challenge();
        //    //Section4Exercises();
        //    Section5Exercises();
        //}

        #region Section 1
        public static void Section1Exercises()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.WriteLine("Section 1 (Your First C# Program and an Overview of VS) Exercise");
            Console.WriteLine("Hello Frog World!");
        }
        #endregion Section 1
        #region Section 2
        public static void Section2Exercises()
        {
            Console.WriteLine("Section 2 (Datatypes and Variables) Exercises");

            // Ints and doubles
            Console.WriteLine();
            Console.WriteLine("Portion: ints and doubles");

            int num1 = 13;
            int num2 = 5;
            int sum = num1 + num2;
            int div = num1 / num2;

            double d1 = 3.5;
            double d2 = 1.337;
            double sumD = d1 + d2;
            double divD = d1 / d2;

            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + sum);
            Console.WriteLine(num1 + " divided by " + num2 + " is " + div);
            Console.WriteLine("The sum of " + d1 + " and " + d2 + " is " + sumD);
            Console.WriteLine(d1 + " divided by " + d2 + " is " + divD);

            // Strings
            Console.WriteLine();
            Console.WriteLine("Portion: strings");

            string myname = "Sierra Jo";
            string message = "My name is " + myname;
            string capsMessage = message.ToUpper();
            string lowerMessage = message.ToLower();

            Console.WriteLine(capsMessage);
            Console.WriteLine(lowerMessage);

            // Explicit conversion
            Console.WriteLine();
            Console.WriteLine("Portion: explicit conversion");

            double myDouble = 13.37;
            int myInt;
            myInt = (int)myDouble;
            Console.WriteLine(myInt);

            // Implicit conversion
            Console.WriteLine();
            Console.WriteLine("Portion: implicit conversion");

            int num = 123456789;
            long bigNum = num;
            Console.WriteLine(bigNum);

            // Type conversion
            Console.WriteLine();
            Console.WriteLine("Portion: type conversion");

            string myString = myDouble.ToString();
            Console.WriteLine(myString);

            // Type conversion woorks with bools too!
            bool sunIsShining = false;
            string isSunShining = sunIsShining.ToString();
            Console.WriteLine("Is the sun shining? " + isSunShining);

            // Parsing strings to ints
            Console.WriteLine();
            Console.WriteLine("Portion: parsing");

            string stringNum1 = "15";
            string stringNum2 = "13";
            int intNum1 = Int32.Parse(stringNum1);
            int intNum2 = Int32.Parse(stringNum2);

            string concatResult = stringNum1 + stringNum2;
            int sumResult = intNum1 + intNum2;
            Console.WriteLine(stringNum1 + " concated plus " + stringNum2 + " is " + concatResult);
            Console.WriteLine(intNum1 + " plus " + intNum2 + " is " + sumResult);

            // Constants
            Console.WriteLine();
            Console.WriteLine("Portion: constants");

            const string BDAY = "10/17/1997";
            Console.WriteLine("My birthday is always going to be {0}", BDAY);
        }

        public static void Section2Challenge()
        {
            Console.WriteLine("Section 2 Challenge: Datatypes and Variables");
            Console.WriteLine();

            // Create a variable for each of the primitive datatypes
            // Leave the Object datatype out

            // byte [0-255]
            byte b = 254;
            Console.WriteLine("Datatype: byte");
            Console.WriteLine(b);
            Console.WriteLine();

            // sbyte [(-128)-127]
            sbyte sb = -25;
            Console.WriteLine("Datatype: signed byte");
            Console.WriteLine(sb);
            Console.WriteLine();

            // int [(-2,147,483,648)-2,147,483,647]
            int i = 32;
            Console.WriteLine("Datatype: int");
            Console.WriteLine(i);
            Console.WriteLine();

            // uint [0-4,294,967,295]
            uint ui = 249;
            Console.WriteLine("Datatype: unsigned int");
            Console.WriteLine(ui);
            Console.WriteLine();

            // short [(-32,768)-32,767]
            short s = -42;
            Console.WriteLine("Datatype: short");
            Console.WriteLine(s);
            Console.WriteLine();

            // ushort [0-65,535]
            ushort us = 502;
            Console.WriteLine("Datatype: unsigned short");
            Console.WriteLine(us);
            Console.WriteLine();

            // long [(-9,223,372,036,854,775,808)-9,223,372,036,854,775,807]
            long l = 123456789876543210;
            Console.WriteLine("Datatype: long");
            Console.WriteLine(l);
            Console.WriteLine();

            // ulong [0-18,446,744,073,709,551,615]
            ulong ul = 222222222222;
            Console.WriteLine("Datatype: unsigned long");
            Console.WriteLine(ul);
            Console.WriteLine();

            // float [(-3.402823e38)-3.402823e38]
            float f = 42.1239F;
            Console.WriteLine("Datatype: float");
            Console.WriteLine(f);
            Console.WriteLine();

            // double [(-1.79769313486232e308)-1.79769313486232e308]
            double d = -54.92;
            Console.WriteLine("Datatype: double");
            Console.WriteLine(d);
            Console.WriteLine();

            // char
            char c = 'c';
            Console.WriteLine("Datatype: char");
            Console.WriteLine(c);
            Console.WriteLine();

            // bool
            bool boo = false;
            Console.WriteLine("Datatype: boolean");
            Console.WriteLine(boo);
            Console.WriteLine();

            //decimal [±1.0 × 10e−28-±7.9 × 10e28]
            decimal dec = 13.13131313M;
            Console.WriteLine("Datatype: decimal");
            Console.WriteLine(dec);
            Console.WriteLine();

            // string
            Console.WriteLine("Datatype: string");

            string cntrl = "I control text";
            Console.WriteLine(cntrl);

            string num = "25";
            int iNum = Int32.Parse(num);
            Console.WriteLine(iNum);
        }
        #endregion Section 2
        #region Section 3
        public static void Section3Exercises()
        {
            Console.WriteLine("Section 3 (Functions/Methods and How to Save Time) Exercises");
            
            Console.WriteLine();
            Console.WriteLine("Method: Add2Ints");

            int sum = Add2Ints(2, 3);
            Console.WriteLine(sum);

            Console.WriteLine(Add2Ints(13, 21));

            Console.WriteLine();
            Console.WriteLine("Method: WriteSomething");
            WriteSomething();

            Console.WriteLine();
            Console.WriteLine("Method: WriteSomethingSpecific");
            WriteSomethingSpecific("something specific");

            Console.WriteLine();
            Console.WriteLine("Method: ReadAndWriteSomething");
            ReadAndWriteSomething();

            Console.WriteLine();
            Console.WriteLine("Method: AddTwoInputs");
            AddTwoInputs();

            Console.WriteLine();
            Console.WriteLine("Method: AddTwoInputsTryCatch");
            AddTwoInputsTryCatch();

            Console.WriteLine();
            Console.WriteLine("Method: UnaryOperators");
            UnaryOperators();

            Console.WriteLine();
            Console.WriteLine("Method: IncrementDecrementPperators");
            IncrementDecrementOperators();

            Console.WriteLine();
            Console.WriteLine("Method: ArithmeticOperators");
            ArithmeticOperators();

            Console.WriteLine();
            Console.WriteLine("Method: RelationalAndTypeOperators");
            RelationalAndTypeOperators();

            Console.WriteLine();
            Console.WriteLine("Method: ConditionalOperators");
            ConditionalOperators();
        }

        public static int Add2Ints(int num1, int num2)
        {
            return num1 + num2;
        }
        public static void WriteSomething()
        {
            Console.WriteLine("Something");
        }
        public static void WriteSomethingSpecific(string specific)
        {
            Console.WriteLine(specific);
        }
        public static void ReadAndWriteSomething()
        {
            Console.WriteLine("Input something:");
            string input = Console.ReadLine();
            Console.WriteLine(input);
        }
        public static void AddTwoInputs()
        {
            Console.WriteLine("Enter your first number:");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number:");
            int num2 = Int32.Parse(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("The sum of the two numbers is: " + sum);
        }
        public static void AddTwoInputsTryCatch()
        {
            Console.WriteLine("Enter your first number:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter your second number:");
            string input2 = Console.ReadLine();

            try
            {
                int num1 = Int32.Parse(input1);
                int num2 = Int32.Parse(input2);
                int sum = num1 + num2;
                Console.WriteLine("The sum of the two numbers is " + sum);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void UnaryOperators()
        {
            int num1 = 5;
            int num3 = -num1;
            Console.WriteLine(num3);

            bool isSunny = true;
            Console.WriteLine(!isSunny);
        }
        public static void IncrementDecrementOperators()
        {
            int num = 7;

            Console.WriteLine("Original value: " + num);
            // Increment
            Console.WriteLine("num++");
            Console.WriteLine(num++);
            Console.WriteLine(num);
            // Pre-Increment
            Console.WriteLine("++num");
            Console.WriteLine(++num);
            Console.WriteLine(num);
            // Decrement
            Console.WriteLine("num--");
            Console.WriteLine(num--);
            Console.WriteLine(num);
            // Pre-Decrement
            Console.WriteLine("--num");
            Console.WriteLine(--num);
            Console.WriteLine(num);
        }
        public static void ArithmeticOperators()
        {
            int num1 = 127;
            int num2 = 33;
            Console.WriteLine("{0} plus {1} is {2}", num1, num2, num1 + num2);
            Console.WriteLine("{0} minus {1} is {2}", num1, num2, num1 - num2);
            Console.WriteLine("{0} divided by {1} is {2}", num1, num2, num1 / num2);
            Console.WriteLine("The remainder of {0} divided by {1} is {2}", num1, num2, num1 % num2);
        }
        public static void RelationalAndTypeOperators()
        {
            int num1 = 73;
            int num2 = 30;
            bool isLower = num1 < num2;
            bool isHigher = num1 > num2;
            bool isEqual = num1 == num2;
            bool isNotEqual = num1 != num2;

            Console.WriteLine("{0} is lower in value than {1}: {2}", num1, num2, isLower);
            Console.WriteLine("{0} is higher in value than {1}: {2}", num1, num2, isHigher);
            Console.WriteLine("{0} is equal in value to {1}: {2}", num1, num2, isEqual);
            Console.WriteLine("{0} is not equal in value to {1}: {2}", num1, num2, isNotEqual);
        }
        public static void ConditionalOperators()
        {
            bool isSunny = true;
            bool isRaining = false;
            bool isNiceDay = isSunny && (!isRaining);
            bool isBadDay = (!isSunny) || isRaining;
            Console.WriteLine("Is it sunny? {0}", isSunny);
            Console.WriteLine("Is it raining? {0}", isRaining);
            Console.WriteLine("Is it a nice day? {0}", isNiceDay);
            Console.WriteLine("Is it a bad day? {0}", isBadDay);
        }
        public static void Section3Challenge()
        {
            string friend1 = "Cheyenne";
            string friend2 = "Bayleigh";
            string friend3 = "Sierra";
            GreetFriend(friend1);
            GreetFriend(friend2);
            GreetFriend(friend3);
        }
        public static void GreetFriend(string name)
        {
            Console.WriteLine("Hi " + name + ", my friend!");
        }
        #endregion Section 3
        #region Section 4
        public static void Section4Exercises()
        {
            Console.WriteLine("Section 4 (Making Decisions) Exercises");

            Console.WriteLine();
            Console.WriteLine("Portion: IF/ELSE blocks");

            Console.WriteLine("What's the temperature (in Farenheit degrees)?");

            string tempString = Console.ReadLine();
            int numTemp;
            int number;

            if (int.TryParse(tempString, out number))
            {
                numTemp = number;
            }
            else
            {
                numTemp = 0;
                Console.WriteLine("Value entered was not a number. 0 set as temperature.");
            }

            if (numTemp < 30)
            {
                Console.WriteLine("Bundle up! It's c-cold!");
            }
            else if (numTemp < 50)
            {
                Console.WriteLine("Pretty chilly! Hope for sunshine!");
            }
            else if (numTemp < 70)
            {
                Console.WriteLine("Enjoy this nice day!");
            }
            else if (numTemp < 90)
            {
                Console.WriteLine("Wear shorts!");
            }
            else
            {
                Console.WriteLine("Gee whiz! It's hot!");
            }

            Console.WriteLine();
            Console.WriteLine("Portion: Nested IF statements");

            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";

            Console.WriteLine("Please enter your user name.");
            userName = Console.ReadLine();

            if (isRegistered)
            {
                if (userName != "")
                {
                    if (isAdmin)
                    {
                        Console.WriteLine("Hi there, Admin {0}!", userName);
                    }
                    else
                    {
                        Console.WriteLine("Hi there, {0}!", userName);
                    }
                }
                else
                {
                    Console.WriteLine("Hi there, registered user!");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Portion: Enhanced IF statements");

            int temperature = 400;
            string stateOfMatter1;
            string stateOfMatter2;

            if (temperature < 32)
            {
                stateOfMatter1 = "solid";
            }
            else 
            {
                stateOfMatter1 = "liquid";
            }

            stateOfMatter2 = temperature < 32 ? "solid" : "liquid";

            Console.WriteLine("Regular IF/ELSE statement: " + stateOfMatter1);
            Console.WriteLine("Enhanced IF/ELSE statement: " + stateOfMatter2);

            // a ? b : c ? d : e
            // is evaluated as
            // a ? b : (c ? d : e)

            string stateOfMatter3;
            string stateOfMatter4;

            if (temperature < 32)
            {
                stateOfMatter3 = "solid";
            }
            else if (temperature < 212)
            {
                stateOfMatter3 = "liquid";
            }
            else
            {
                stateOfMatter3 = "gas";
            }

            stateOfMatter4 = temperature < 32 ? "solid" : temperature < 212 ? "liquid" : "gas";

            Console.WriteLine("Regular IF/ELSEIF/ELSE statement: " + stateOfMatter3);
            Console.WriteLine("Enhanced IF/ELSEIF/ELSE statement: " + stateOfMatter4);

        }
        #endregion Section 4
        #region Section 5
        public static void Section5Exercises()
        {
            Console.WriteLine("Section 5 (Loops) Exercises");

            Console.WriteLine();
            Console.WriteLine("Portion: for loops");

            for (int cnt = 0; cnt < 50; cnt+=5)
            {
                Console.WriteLine(cnt);
            }

            for (int cnt = 1; cnt < 100; cnt+=2)
            {
                Console.WriteLine(cnt);
            }

            Console.WriteLine();
            Console.WriteLine("Portion: do while loops");

            int lengthOfText = 0;
            do
            {
                Console.WriteLine("Please enter your name");
                string name = Console.ReadLine();
                int currentLength = name.Length;
                lengthOfText += currentLength;
            } while (lengthOfText <= 0);

            Console.WriteLine();
            Console.WriteLine("Portion: while loops");

            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }

            int studentCount = 0;
            bool isCounting = true;
            Console.WriteLine("You have begun counting.");

            while (isCounting)
            {
                string userInput = Console.ReadLine();
                if (userInput.Equals(""))
                {
                    studentCount++;
                }
                else
                {
                    isCounting = false;
                    Console.WriteLine();
                    Console.WriteLine("You have stopped counting.");
                    Console.WriteLine("Student count is {0}.", studentCount);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Portion: break and continue");

            for (int j=0; j<10; j++)
            {
                Console.WriteLine(j);
                if (j == 3)
                {
                    Console.WriteLine("At 3 we stop.");
                    break;
                }
            }

            for (int k=0; k<10; k++)
            {
                if (k == 5)
                {
                    Console.WriteLine("We skip 5!");
                    continue;
                }
                Console.WriteLine(k);
            }
        }
        #endregion Section 5
    }
}
