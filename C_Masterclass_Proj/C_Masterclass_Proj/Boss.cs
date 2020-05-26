using System;
using System.Collections.Generic;
using System.Text;

namespace C_Masterclass_Proj
{
    class Boss :Employee
    {
        private string CompanyCar { get; set; }

        public Boss() { }

        public Boss(string JobTitle, string FirstName, string LastName, double Salary, string CompanyCar) : base(JobTitle, FirstName, LastName, Salary)
        {
            this.CompanyCar = CompanyCar;
        }

        public void Lead()
        {
            Console.WriteLine("*insert leadership*");
        }

        public new void Introduce()
        {
            Console.WriteLine("Hi! My name is {0} {1} and I'm a {2}. Do you want to see the {3} the company gave me?", this.FirstName, this.LastName, this.JobTitle, this.CompanyCar);
        }
    }
}
