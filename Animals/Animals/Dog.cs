using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Dog : Animal
    {
        private string name;

        public Dog(string name, string owner)
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

    }

}

