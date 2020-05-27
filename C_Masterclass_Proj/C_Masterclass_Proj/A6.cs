using System;
using System.Collections.Generic;
using System.Text;

namespace C_Masterclass_Proj
{
    class A6 :Audi
    {
        public A6(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
            this.Model = "A6";
        }

        public override void ShowDetails()
        {
            Console.WriteLine("**Brand: {0}, Model: {1}, ID: {2}, HP: {3}, color: {4}", this.brand, this.Model, this.id.ID, this.HP, this.Color);
        }

        // Keyword 'sealed' restricts other classes from overriding this method
        // Keyword 'virtual' allows other classes to override this method
        // Keyword 'sealed' must be used alongside 'override'
        public sealed override void Repair()
        {
            Console.WriteLine("BLAH!");
        }
    }
}
