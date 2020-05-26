using System;
using System.Collections.Generic;
using System.Text;

namespace C_Masterclass_Proj
{
    class Trainee :Employee
    {
        private double WorkingHours { get; set; }
        private double SchoolHours { get; set; }

        public Trainee() { }

        public Trainee(string JobTitle, string FirstName, string LastName, double Salary, double WorkingHours, double SchoolHours):base(JobTitle,FirstName,LastName,Salary)
        {
            this.WorkingHours = WorkingHours;
            this.SchoolHours = SchoolHours;
        }

        public new void Introduce()
        {
            Console.WriteLine("Hi! My name is {0} {1} and I'm training to be a {2}! I'm currently working {3} hours and going to school for {4} hours.", this.FirstName, this.LastName, this.JobTitle, this.WorkingHours, this.SchoolHours);
        }
    }
}
