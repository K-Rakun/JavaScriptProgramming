using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Catalogue
{
    public class Car
    {
        private float regNum;
        private int year;
        private string color;
        private string costumColor;

        public Car()
        {
            
            
        }

        public float RegNum
        {
            get { return regNum; }
            set
            {
                if (value > 9999999999) 
                {
                    throw new Exception();
                }
                try{regNum = value;}
                catch (Exception)
                {
                    Console.WriteLine("Invalid Registration Number");
                }
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if(year < 1900 || year > 2050)
                {
                    throw new Exception("Invalid year");
                }
                year = value;
                
            }
        }

        public CarMaker Make { get; set; }

        public CarModel Model { get; set; }

        public CarColor Color { get; set; }

        public string CostumColor
        {
            get => costumColor;
            set
            {
                if (Color == CarColor.other)
                {
                    CostumColor = string.Empty;
                }
                color = value;
            }
        }
    }
}
