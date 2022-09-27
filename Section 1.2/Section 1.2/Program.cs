using System;

namespace Section_1._2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter your fuel consumption in liter per 100 kilometers or miles per gallon to have it converted to other");

            var fuelConsmption = double.Parse(Console.ReadLine());

            //liter per 100 kilemeters to miles per gallon formula is same as miles per gallon to liter per 100 kilemeters formula which is
            //235.215 / (your fuel consumption) so this works both ways
            double ConvertionResult = 235.215 / fuelConsmption ;

            Console.WriteLine("Convertion complete");

            Console.WriteLine(ConvertionResult);
        }
    }
}
