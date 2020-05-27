using System;
using System.Collections.Generic;
using System.Text;

namespace C_Masterclass_Proj
{
    class M3 :BMW
    {
        public M3(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
            this.Model = "M3";
        }

        public override void ShowDetails()
        {
            Console.WriteLine("**Brand: {0}, Model: {1}, ID: {2}, HP: {3}, color: {4}", this.brand, this.Model, this.id.ID, this.HP, this.Color);
        }
    }
}
