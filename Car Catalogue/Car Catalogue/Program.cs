using System;

namespace Car_Catalogue
{
    class Program
    {
        static void Main()
        {
            Car car1 = new Car();
            car1.RegNum = 123;
            car1.Year = 2012;
            car1.Make = CarMaker.toyota;
            car1.Model = CarModel.corolla;
            car1.Color = CarColor.red;

        }
    }
}
