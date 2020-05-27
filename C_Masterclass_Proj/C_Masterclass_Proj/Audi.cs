using System;
using System.Collections.Generic;
using System.Text;

namespace C_Masterclass_Proj
{
    class Audi :Car
    {
        protected string brand = "Audi";

        protected string Model { get; set; }

        public Audi() { }

        public Audi(int hp, string color, string model) : base(hp, color)
        {
            this.Model = model;
        }

        // Keyword 'override' needs keyword 'virtual' in parent function
        public override void ShowDetails()
        {
            Console.WriteLine("Brand: {0}, Model: {1}, ID: {2}, HP: {3}, color: {4}", this.brand, this.Model, this.id.ID, this.HP, this.Color);
        }

        public virtual void Repair()
        {
            Console.WriteLine("The BMW {0} has been repaired.", this.Model);
        }
    }
}
