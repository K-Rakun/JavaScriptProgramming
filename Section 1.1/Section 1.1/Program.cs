using System;

namespace Section_1._1
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Please enter a temperature in Celsius");

            var num1Celsius = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a temperature in Fahrenheit");

            var num2Fahrenheit = double.Parse(Console.ReadLine());

            //variables for later use
            double FahrenheitDifirence;
            double CelsiusDifirance;
            double num1Fahrenheit = (num1Celsius * 1.8) + 32;
            double num2Celsius = (num2Fahrenheit - 32) * 5/9;
            



            if (num1Fahrenheit>num2Fahrenheit)
            {

                FahrenheitDifirence = num1Fahrenheit - num2Fahrenheit;

                CelsiusDifirance = num1Celsius - num2Celsius;


                Console.WriteLine($"{num1Celsius} Celsius is {FahrenheitDifirence} Fahrenheit bigger than {num2Fahrenheit} Fahrenheit");


                Console.WriteLine($"{num1Celsius} Celsius is {CelsiusDifirance} Celsius bigger than {num2Fahrenheit} Fahrenheit");

            }
            else if (num1Fahrenheit<num2Fahrenheit)
            {
              
                FahrenheitDifirence = num2Fahrenheit - num1Fahrenheit;

                CelsiusDifirance = num2Celsius - num1Celsius;

                Console.WriteLine($"{num2Fahrenheit} Fahrenheit is {FahrenheitDifirence} Fahrenheit bigger than {num1Celsius} Celsius");


                Console.WriteLine($"{num2Fahrenheit} Fahrenheit is {CelsiusDifirance} Celsius bigger than {num1Celsius} Celsius");

            }
            else
            {


                Console.WriteLine("Both temperatures are equal");



            }
        }
    }
}
