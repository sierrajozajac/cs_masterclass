using System;
using System.Collections.Generic;
using System.Text;

namespace C_Masterclass_Proj
{
    class BMW : Car
    {
        protected string brand = "BMW";

        protected string Model { get; set; }

        public BMW() { }

        public BMW(int hp, string color, string model):base(hp, color)
        {
            this.Model = model;
        }

        // Keyword 'new' does not need keyword 'virtual'
        // HOWEVER there are now two functions with the same name and the programmer will now have to be more specific
        public new virtual void ShowDetails()
        {
            Console.WriteLine("Brand: {0}, Model: {1}, ID: {2}, HP: {3}, color: {4}",this.brand, this.Model, this.id.ID,this.HP, this.Color);
        }

        public void Repair()
        {
            Console.WriteLine("The BMW {0} has been repaired.", this.Model);
        }
    }
}
