using System;
using System.Collections.Generic;
using System.Text;

namespace C_Masterclass_Proj
{
    class Employee
    {
        public string JobTitle { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }

        public Employee() { }

        public  Employee(string JobTitle, string FirstName, string LastName, double Salary)
        {
            this.JobTitle = JobTitle;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Salary = Salary;
        }

        public void Introduce()
        {
            Console.WriteLine("Hi! My name is {0} {1} and I'm a {2}.", this.FirstName, this.LastName, this.JobTitle);
        }

        public void AskAboutSalary()
        {
            Console.WriteLine("I'm pretty sure we aren't supposed to talk about that...");
        }

        public void Work()
        {
            Console.WriteLine("I'm working.");
        }

        public void Pause()
        {
            Console.WriteLine("I'm having a break.");
        }
    }
}
