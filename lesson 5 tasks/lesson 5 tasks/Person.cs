using System;
using System.Collections.Generic;
using System.Text;

namespace lesson_5_tasks
{
    class Person
    {
        private string name;
        private int age;
        public string Name
        {

            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("invalid name");
                }
                name = value;
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if(value < 0 || value > 100) { throw new Exception("invalid name"); }
                age = value;
            }
        }
        
        



    }
}
