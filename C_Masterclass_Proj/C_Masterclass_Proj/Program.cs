using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Text.Json;
using System.Threading;
using System.Transactions;

namespace C_Masterclass_Proj
{
    struct Game
    {
        public string name;
        public string developer;
        public double rating;
        public string releaseDate;

        public Game(string name, string developer, double rating, string releaseDate)
        {
            this.name = name;
            this.developer = developer;
            this.rating = rating;
            this.releaseDate = releaseDate;
        }

        public void Display()
        {
            Console.WriteLine("Instance of game struct.");
            Console.WriteLine("Game name: " + name);
            Console.WriteLine("Game was developed by: " + developer);
            Console.WriteLine("Game rating: " + rating);
            Console.WriteLine("Game was released: " + releaseDate);
            Console.WriteLine();
        }
    }
    enum Day { Mon=2, Tues, Wed, Thurs, Fri, Sat, Sun=1 };
    enum Month { Jan=1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec };

    class Program
    {
        static void Main(string[] args)
        {
            //Section1Exercises();
            //Section2Exercises();
            //Section2Challenge();
            //Section3Exercises();
            //Section3Challenge();
            //Section4Exercises();
            //Section5Exercises();
            //OOP_Exercises();
            //ArrayListExercises();
            //Section9Exercises();
            //PolymorphismExercises();
            //TextFileExercises();
            //Section11Exercises();
            //DelegateExercises();
            //EventExercises();
            WPF_Exercises();
            DatabaseExercises();
            LinqExercises();
            ThreadingExercises();
        }

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
        #region Section 6
        public static void OOP_Exercises()
        {
            Human sierra = new Human("Sierra", "Sallee", 22, "green");
            sierra.IntroduceMyself();

            Human dennis = new Human("Dennis");
            dennis.IntroduceMyself();

            Human sharon = new Human("Sharon", "Reed");
            sharon.IntroduceMyself();

            Human reece = new Human("Reece", "Sallee", 1);
            reece.IntroduceMyself();
            reece.HappyBirthday();
            reece.IntroduceMyself();

            Human notCyborg = new Human(500, "purple");
            notCyborg.IntroduceMyself();
        }
        #endregion Section 6
        #region Section 7
        public static void ArrayListExercises()
        {
            int[] nums = new int[10];

            for (int i=0; i<10; i++)
            {
                nums[i] = i * i;
            }

            int cnt = 0;
            foreach (int n in nums)
            {
                Console.WriteLine("Element #" + cnt++ + ": " + n);
            }

            // Create an array with 5 of your best friends
            string[] friends = new string[5];
            friends[0] = "Marcus";
            friends[1] = "Cheyenne";
            friends[2] = "Bayleigh";
            friends[3] = "Shawnasea";
            friends[4] = "Sierra";
            // Shorter version below
            // string[] friends = { "Marcus", "Cheyenne", "Bayleigh", "Shawnasea", "Sierra" };

            // Create a foreach loop which greets all of your friends
            foreach (string friend in friends)
            {
                Console.WriteLine("Hello " + friend + ", my friend!");
            }

            int[,] matrix = new int[,]
            {
                {7,8,9},
                {4,5,6},
                {1,2,3}
            };

            Console.WriteLine("Central value is {0}.", matrix[1, 1]);
            
            for (int i=0; i<3; i++)
            {
                string ret = "| ";
                Console.WriteLine("+---+---+---+");
                for (int j=0; j<3; j++)
                {
                    ret += matrix[i, j];
                    ret += " | ";
                }
                Console.WriteLine(ret);
            }
            Console.WriteLine("+---+---+---+");

            string[,,] threeD = new string[,,]
            {
                {
                    {"000","001","002"},
                    {"010","011","012"},
                    {"020","021","022"}
                },
                {
                    {"100","101","102"},
                    {"110","111","112"},
                    {"120","121","122"}
                },
                {
                    {"200","201","202"},
                    {"210","211","212"},
                    {"220","221","222"}
                }
            };

            Console.WriteLine("threeD[1,1,2]: {0}", threeD[1, 1, 2]);
            Console.WriteLine("threeD[2,1,2]: {0}", threeD[2, 1, 2]);
            Console.WriteLine("threeD[0,2,0]: {0}", threeD[0, 2, 0]);

            int dimensions = threeD.Rank;
            Console.WriteLine("Number of dimensions: {0}", dimensions);

            int[,,] mtrx = new int[3, 5, 7];

            int xCnt = mtrx.GetLength(0);
            int yCnt = mtrx.GetLength(1);
            int zCnt = mtrx.GetLength(2);

            Console.WriteLine("Matrix width: " + xCnt);
            Console.WriteLine("Matrix height: " + yCnt);
            Console.WriteLine("Matrix length: " + zCnt);

            // Jagged array = array within array
            int[][] jag = new int[3][];

            jag[0] = new int[5];
            jag[1] = new int[] { 1, 2, 3, 5, 8 };
            jag[2] = new int[2];

            int[][] jig = new int[][]
            {
                new int[] { 2,4,3,7,11},
                new int[] { 1,2,3}
            };

            Console.WriteLine(jag[1][2]);
            Console.WriteLine(jig[0][3]);

            string[][] families = new string[][]
            {
                new string[] {"Mark", "Dawn", "Sierra", "Reece", "Marcos"},
                new string[] {"Joe", "Sharon", "Zenda", "Jo Dawn", "Krystal"}
            };

            for (int i=0; i<families.Length; i++)
            {
                Console.WriteLine("Hello family #{0}!", i+1);
                for (int j=0; j<families[i].Length; j++)
                {
                    Console.WriteLine("Welcome, {0}!", families[i][j]);
                }
            }

            int[] ary = new int[] { 10, 5, 19, 23, 7 };
            Console.WriteLine(GetAverage(ary));

            ArrayList arrayList = new ArrayList();
            arrayList.Add("Hello");
            arrayList.Add(13.37);
            arrayList.Add(200);

            for (int i=0; i<arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }

            foreach (Object obj in arrayList)
            {
                Console.WriteLine(obj);
            }

            List<int> list = new List<int> { 1, 2, 3, 4, 5 };
            list.Add(0);
            list.RemoveRange(2, 2);
            list.Sort();
            list.ForEach(i => Console.WriteLine(i));
        }
        public static double GetAverage(int[] values)
        {
            int size = values.Length;
            double avg;
            int sum = 0;

            for (int i=0; i<size; i++)
            {
                sum += values[i];
            }

            avg = (double)sum / size;
            return avg;
        }
        #endregion Section 7
        #region Section 9
        public static void Section9Exercises()
        {
            // Challenge 1
            VideoPost videoPost1 = new VideoPost("FailVideo", true, "Denis Panjuta",
                "https://video.com/failvideo", 10);

            Console.WriteLine(videoPost1.ToString());

            Console.WriteLine("Press any key to begin the video!");
            Console.ReadKey();
            videoPost1.Play();
            Console.WriteLine("Press any key to stop the video!");
            Console.ReadKey();
            videoPost1.Stop();

            // Challenge 2

            Employee Mike = new Employee("Hacker", "Michael", "Miller", 60000);
            Mike.Introduce();
            Mike.Work();
            Mike.Pause();

            Boss Harvey = new Boss("Manager", "Harvey", "Jones", 90000, "Buick");
            Harvey.Introduce();
            Harvey.Lead();
            Harvey.AskAboutSalary();

            Trainee John = new Trainee("Suck up", "John", "Doe", 5000, 20, 14);
            John.Introduce();
        }
        #endregion Section 9
        #region Section 10
        public static void PolymorphismExercises()
        {
            Car c1 = new Car(200, "red");
            BMW b1 = new BMW(340, "blue", "sedan");
            Audi a1 = new Audi(230, "green", "car");

            List<Car> carList = new List<Car>
            {
                c1, b1, a1
            };

            foreach (Car curCar in carList)
            {
                curCar.ShowDetails();
            }
            Console.WriteLine();

            // This shows the difference between the use of 'new' versus 'override'

            // Using 'new'
            Console.WriteLine("Using the keyword 'new'");
            b1.ShowDetails();
            Car c2 = (Car)b1;
            c2.ShowDetails();

            Console.WriteLine();

            M3 m3_1 = new M3(230, "purple");
            m3_1.ShowDetails();
            BMW b2 = (BMW)m3_1;
            b2.ShowDetails();
            Car c3 = (Car)b2;
            c3.ShowDetails();
            Car c4 = (Car)m3_1;
            c4.ShowDetails();

            // Using 'override'
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Using the keyword 'override'");
            a1.ShowDetails();
            Car c5 = (Car)a1;
            c5.ShowDetails();

            Console.WriteLine();

            A6 a6_1 = new A6(420, "green");
            a6_1.ShowDetails();
            Audi a2 = (Audi)a6_1;
            a2.ShowDetails();
            Car c6 = (Car)a2;
            c6.ShowDetails();
            Car c7 = (Car)a6_1;
            c7.ShowDetails();
        }
        public static void TextFileExercises()
        {
            // C:\Users\Owner\Documents\GitHub\cs_masterclass

            // Writing method #1
            string[] lines = { "First 250", "Second 242", "Third 240" };

            System.IO.File.WriteAllLines(@"C:\Users\Owner\Documents\GitHub\cs_masterclass\highscores.txt", lines);

            /*
            // Writing method #2
            Console.WriteLine("Please give the file a name");
            string fileName = Console.ReadLine();
            Console.WriteLine("Please enter the text for the file");
            string input = Console.ReadLine();
            File.WriteAllText(@"F:\C# Masterclass Course\Projects\Assets\" + fileName + ".txt", input);
            */

            // Writing method #3
            using (StreamWriter file = new StreamWriter(@"C:\Users\Owner\Documents\GitHub\cs_masterclass\myText2.txt"))
            {
                foreach (string line in lines)
                {
                    if (line.Contains("2"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            using (StreamWriter file = new StreamWriter(@"C:\Users\Owner\Documents\GitHub\cs_masterclass\myText2.txt", true))
            {
                file.WriteLine("Additional line");
            }

            //Reading Text from a File
            //exchange the adress of the file with the one you want to use
            string text = System.IO.File.ReadAllText(@"C:\Users\Owner\Documents\GitHub\cs_masterclass\myText2.txt");

            Console.WriteLine("Textfile contains the following text: {0}", text);

            //Receive the Text line by line.
            string[] linesIn = System.IO.File.ReadAllLines(@"C:\Users\Owner\Documents\GitHub\cs_masterclass\myText2.txt");

            Console.WriteLine("Content of the file line by line:");
            foreach (string line in linesIn)
            {
                //\t is a tab
                Console.WriteLine( "\t" + line);
            }

            //To keep the Console open.
            Console.Read();
        }
        #endregion Section 10
        #region Section 11
        public static void Section11Exercises()
        {
            // Structs
            Game game1;
            game1.name = "Pokemon Go";
            game1.developer = "Niantic";
            game1.rating = 3.5;
            game1.releaseDate = "01/07/2016";

            Console.WriteLine("Instance of game struct.");
            Console.WriteLine("Game name: " + game1.name);
            Console.WriteLine();

            Game game2 = new Game("Witcher", "Who Knows", 4.1, "01/01/2000");
            game2.Display();

            // Enums
            Day fr = Day.Fri;
            Day sa = Day.Sat;

            Console.WriteLine(fr - sa);
            Console.WriteLine(fr - fr);
            Console.WriteLine();

            Day curr = Day.Sun;
            for(int i=0; i<7; i++)
            {
                Console.WriteLine(curr);
                Console.WriteLine((int)curr);
                curr++;
            }
            Console.WriteLine();

            Console.WriteLine(Month.Feb);
            Console.WriteLine((int)Month.Feb);
            Console.WriteLine();

            // Math class
            double ceil = Math.Ceiling(3.5);
            double flor = Math.Floor(3.5);

            Console.WriteLine();
            Console.WriteLine("Ceiling of 3.5 is {0}", ceil);
            Console.WriteLine("Floor of 3.5 is {0}", flor);

            int num1 = 13;
            int num2 = 9;

            Console.WriteLine();
            Console.WriteLine("The lowest number between {0} and {1} is {2}.", num1, num2, Math.Min(num1,num2));
            Console.WriteLine("The highest number between {0} and {1} is {2}.", num1, num2, Math.Max(num1, num2));

            Console.WriteLine();
            Console.WriteLine("3 to the power of 5 is {0}.", Math.Pow(3, 5));
            Console.WriteLine("The square root of 81 is {0}.", Math.Sqrt(81));

            Console.WriteLine();
            Console.WriteLine("Pi is equal to {0}.", Math.PI);
            Console.WriteLine();

            // Random class
            Random dice = new Random();
            int numEyes;

            for(int i=0; i<10; i++)
            {
                numEyes = dice.Next(1, 7);
                Console.WriteLine("I rolled a {0}!", numEyes);
            }
            Console.WriteLine();

            Random fortuneTeller = new Random();
            string outlook;
            string userInput;

            Console.WriteLine("Welcome! Would you like me to tell you your fortune? (y/n)");
            userInput = Console.ReadLine();
            while (userInput.Equals("y"))
            {
                Console.WriteLine("Find a question from deep inside you and let it free.");
                Console.WriteLine("Then the ball will tell what is meant to be!");
                Console.ReadLine();
                switch (fortuneTeller.Next(1,4))
                {
                    case 1:
                        outlook = "good!";
                        break;
                    case 2:
                        outlook = "not so bad...";
                        break;
                    case 3:
                        outlook = "gloomy. Beware!";
                        break;
                    default:
                        outlook = "unclear at this time.";
                        break;
                }
                Console.WriteLine("The outlook is {0}", outlook);
                Console.WriteLine();
                Console.WriteLine("Would you like me to tell your fortune again?");
                userInput = Console.ReadLine();
            }
            Console.WriteLine("Thank you for your time, traveler!");
            Console.WriteLine();

            // Regular expressions

            /*
             * CHARACTER ESCAPES
             * \t 		- Matches a tab
             * \n 		- Matches a new line
             * 
             * CHARACTER CLASSES
             * .       - Wildcard: Matches any single character except \n.
             * \d      - Matches any decimal digit. (0-9)
             * \D      - Matches any character other than a decimal digit. (0-9)
             * \w      - Word Character (a-z, A-Z, 0-9, _)
             * \W      - Not a Word Character
             * \s      - Matches any white-space character. (space, tab, newline)
             * \S      - Matches any non-white-space character (space, tab, newline)
             * [character_group]     - Matches any single character in character_group. By default, the match is case-sensitive.
             * [^character_group]    - Negation: Matches any single character that is not in character_group. By default, characters in character_group are case-sensitive.
             * 
             * ANCHORS
             * ^       - The match must start at the beginning of the string or line.
             * $       - The match must occur at the end of the string or before \n at the end of the line or string.
             * \A	    - The match must occur at the start of the string.
             * \Z 		- The match must occur at the end of the string or before \n at the end of the string.
             * \b      - Word Boundary
             * \B      - Not a Word Boundary
             * 
             * ALTERNATION CONSTRUCTS
             * |       - Either Or
             * 
             * GROUPING CONSTRUCT
             * ( )     - Group
             * 
             * Quantifiers:
             * *       - Matches the previous element zero or more times.
             * +       - Matches the previous element one or more times.
             * ?       - Matches the previous element zero or one time.
             * {n}     - Matches the previous element exactly n times.
             * {n,m}   - Matches the previous element at least n times, but no more than m times.
             */

            // Phone number regex
            // (
            //   ([+]\d)|()
            // ) 
            // (
            //   (\d{3})|([(]\d{3}[)])
            // )
            // ([#]|[ ]|[-])
            // \d{3}
            // ([#]|[ ]|[-])
            // \d{4}

            // All together
            // (([+]\d)|())((\d{3})|([(]\d{3}[)]))([#]|[ ]|[-])\d{3}([#]|[ ]|[-])\d{4}

            // Datetime
            Console.WriteLine("Today is {0}, {1}/{2}.", DateTime.Today.DayOfWeek, DateTime.Today.Month, DateTime.Today.Day);
            string fmt = "00";
            Console.WriteLine("Time is currently {0}:{1}.", DateTime.Now.TimeOfDay.Hours.ToString(fmt), DateTime.Now.TimeOfDay.Minutes.ToString(fmt));
            Console.WriteLine();

            DateTime tomorrow = DateTime.Today.AddDays(1);
            Console.WriteLine("Tomorrow is {0}, {1}/{2}.", tomorrow.DayOfWeek, tomorrow.Month, tomorrow.Day);
            tomorrow = tomorrow.AddDays(1);
            Console.WriteLine("The day after tomorrow is {0}, {1}/{2}.", tomorrow.DayOfWeek, tomorrow.Month, tomorrow.Day);
            tomorrow = tomorrow.AddDays(1);
            Console.WriteLine("The day after that is {0}, {1}/{2}.", tomorrow.DayOfWeek, tomorrow.Month, tomorrow.Day);
            Console.WriteLine();

            DateTime dt = new DateTime(1997,10,17);
            TimeSpan age = DateTime.Now.Subtract(dt);

            Console.WriteLine("I have been alive for approximately {0} seconds.", age.TotalSeconds);
            Console.WriteLine("I have been alive for approximately {0} minutes.", age.TotalMinutes);
            Console.WriteLine("I have been alive for approximately {0} hours.", age.TotalMinutes / 60);
            Console.WriteLine("I have been alive for approximately {0} days.", age.TotalDays);
            Console.WriteLine("I have been alive for approximately {0} months.", age.TotalDays / 30);
            Console.WriteLine("I have been alive for approximately {0} years.", age.TotalDays / 365);
            Console.WriteLine();

            // Nullables
            int? n1 = null;
            int? n2 = 20;

            double? d3 = new Double?();
            double? d4 = 34.123;
            d3 = d4 / n2;

            bool? boolval = null;
            bool? bool2 = new bool?();

            Console.WriteLine("n1: {0}", n1);
            Console.WriteLine("n2: {0}", n2);
            Console.WriteLine("d3: {0}", d3);
            Console.WriteLine("d4: {0}", d4);
            Console.WriteLine("boolval: {0}", boolval.ToString());
            Console.WriteLine("bool2: {0}", bool2.ToString());
            Console.WriteLine();

            boolval = true;
            Console.WriteLine("boolval (again): {0}", boolval.ToString());
            Console.WriteLine("num1 (again) :{0}", n1 ?? 0);
            Console.WriteLine();
        }
        #endregion Section 11
        #region Section 12
        public delegate double PerformCalculation(double x, double y);
        public delegate string GetTextDelegate(string name);
        public static double Addition(double a, double b)
        {
            return a + b;
        }
        public static double Division(double a, double b)
        {
            return a / b;
        }
        public static double Subtraction(double a, double b)
        {
            return a - b;
        }
        public static void DelegateExercises()
        {
            // Delegates

            // Covariance enables to pass a derived type where a base type is expected
            // e.g. FileStream where Stream is expected

            // Contravariance enables to pass a bass type where a derived type is expected
            // e.g. Stream where FileStream is expected

            PerformCalculation getSum = Addition;
            Console.WriteLine("The sum of 123 and 9 is {0}.", getSum(123, 9));
            PerformCalculation getDifference = Subtraction;
            Console.WriteLine("The difference of 123 and 9 is {0}.", getDifference(123, 9));
            PerformCalculation getQuotient = Division;
            Console.WriteLine("The quotient of 123 divided by 9 is {0}.", getQuotient(123, 9));
            PerformCalculation getMulti = getSum + getQuotient;
            Console.WriteLine("The sum + quotient of 123 and 9 is {0}. [{1}]", getMulti(123, 9), getSum(123,9) + getQuotient(123,9));
            getMulti += Subtraction;
            getMulti -= getQuotient;
            Console.WriteLine("The sum + difference of 123 and 9 is now {0}. [{1}]", getMulti(123, 9), getSum(123, 9) + getDifference(123, 9));
            Console.WriteLine();

            // A different option for implementation
            // Anonymous methods
            GetTextDelegate getText = delegate (string name)
            {
                return "Hello, " + name;
            };
            Console.WriteLine(getText("Sierra"));
            Console.WriteLine();

            // Another option (best option!)
            // Lambda expressions

            // Expression lambda
            // Good for one line
            GetTextDelegate getHello = (string name) => { return "Hello, " + name; };
            Console.WriteLine(getHello("world!"));

            // Statement lambda
            // Necessary if more than one line
            GetTextDelegate getWassup = (string name) => {
                Console.WriteLine("WASSUP!!!");
                Console.WriteLine("How you been, {0}?", name);
                return "Wassup, " + name;
            };
            Console.WriteLine(getWassup("Sierra"));

            GetTextDelegate getWelcome = name => "Welcome, " + name;
            Console.WriteLine(getWelcome("Sierra"));

            Console.WriteLine();
        }
        public static void EventExercises()
        {
            var file = new File() { Title = "File 1" };
            var downloadHelper = new DownloadHelper(); // publisher
            var unpackService = new UnpackService(); // receiver
            var notifService = new NotificationService(); // notifier
            downloadHelper.FileDownloaded += unpackService.OnFileDownloaded;
            downloadHelper.FileDownloaded += notifService.OnFileDownloaded;

            downloadHelper.Download(file);
            Console.WriteLine("Lah di dah");
        }
        #endregion Section 12
        #region Section 13
        public static void WPF_Exercises()
        {

        }
        #endregion Section 13
        #region Section 14
        public static void DatabaseExercises()
        {

        }
        #endregion Section 14
        #region Section 15
        public static void LinqExercises()
        {

        }
        #endregion Section 15
        #region Section 16
        public static void ThreadingExercises()
        {

        }
        #endregion Section 16
    }
}
