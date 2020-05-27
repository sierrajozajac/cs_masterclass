using System;
using System.Collections.Generic;
using System.Text;

namespace C_Masterclass_Proj
{
    class Car
    {
        protected int HP { get; set; }
        protected string Color { get; set; }

        protected CarID id { get; } = new CarID("sierrasallee");

        public Car() { }

        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine("ID: {0}, HP: {1}, color: {2}", this.id.ID, this.HP, this.Color);
        }
    }

    class CarID
    {
        private static int cnt = 0;
        public int ID { get; }
        public string owner { get; }

        public CarID(string user)
        {
            this.ID = ++cnt;
            this.owner = user;
        }
    }
}
