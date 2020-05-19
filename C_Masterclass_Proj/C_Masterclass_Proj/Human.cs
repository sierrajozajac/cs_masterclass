using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace C_Masterclass_Proj
{
    class Human
    {
        private string firstName;
        private string lastName;
        private int age;
        private string eyeColor;

        #region Constructors
        public Human()
        {
            firstName = "";
            lastName = "";
            age = 0;
            eyeColor = "";
        }

        public Human(string fname)
        {
            firstName = fname;
            lastName = "";
            age = 0;
            eyeColor = "";
        }

        public Human(string fname, string lname)
        {
            firstName = fname;
            lastName = lname;
            age = 0;
            eyeColor = "";
        }

        public Human(string fname, int a)
        {
            firstName = fname;
            lastName = "";
            age = a;
            eyeColor = "";
        }

        public Human(int a, string clr)
        {
            firstName = "";
            lastName = "";
            age = a;
            eyeColor = clr;
        }

        public Human(string fname, string lname, string clr)
        {
            firstName = fname;
            lastName = lname;
            age = 0;
            eyeColor = clr;
        }

        public Human(string fname, string lname, int a)
        {
            firstName = fname;
            lastName = lname;
            age = a;
            eyeColor = "";
        }

        public Human(string fname, string lname, int a, string clr)
        {
            firstName = fname;
            lastName = lname;
            age = a;
            eyeColor = clr;
        }
        #endregion

        #region Getter Methods
        public string FirstName()
        {
            return firstName;
        }

        public string LastName()
        {
            return lastName;
        }

        public int Age()
        {
            return age;
        }

        public string EyeColor()
        {
            return eyeColor;
        }
        #endregion

        #region Setter Methods

        public void SetFirstName(string val)
        {
            firstName = val;
        }

        public void SetLastName(string val)
        {
            lastName = val;
        }

        public void SetAge(int val)
        {
            age = val;
        }

        public void SetEyeColor(string val)
        {
            eyeColor = val;
        }

        #endregion

        public void IntroduceMyself()
        {
            string greeting = "Hi!";
            string tmp;
            if (!firstName.Equals("") || !lastName.Equals(""))
            {
                greeting += " My name is ";
                greeting += !firstName.Equals("") ? firstName : "";
                tmp = " " + lastName + "!";
                greeting += !lastName.Equals("") ? tmp : "!";
            }
            if (age != 0)
            {
                greeting += " I am ";
                tmp = age + " years old.";
                greeting += age == 1 ? "1 year old." : tmp;
            }
            tmp = " My eye color is " + eyeColor + ".";
            greeting += !eyeColor.Equals("") ? tmp : "";
            Console.WriteLine(greeting);
        }

        public void HappyBirthday()
        {
            age++;
            string tmp = "Happy birthday " + firstName + "!";
            string ret = !firstName.Equals("") ? tmp : "Happy birthday!";
            Console.WriteLine(ret);
        }

        // Finalizer/destructor
        ~Human()
        {
            Console.WriteLine("Deconstruction of human object.");
            Debug.Write("Deconstruction of human object.");
        }
    }
}
