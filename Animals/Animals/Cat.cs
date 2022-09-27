using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Cat : Animal
    {
        private string name;

        public Cat(string name, string owner)
        {
            this.Name = name;
            this.Owner = owner;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Owner
        {
            get;
            set;
        }

        public void SayMeow()
        {
            Console.WriteLine("Meoooooooooow!");
        }
    }

}

