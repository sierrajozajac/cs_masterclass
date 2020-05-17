using System;
using System.Reflection.Metadata;

namespace C_Masterclass_Proj
{
    class Program
    {
        static void Main(string[] args)
        {
            //Section1Exercises();
            Section2Exercises();
            //Section2Challenge();
        }

        public static void Section1Exercises()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.WriteLine("Section 1 (Your First C# Program and an Overview of VS) Exercise");
            Console.WriteLine("Hello Frog World!");
        }

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
    }
}
