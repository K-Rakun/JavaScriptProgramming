using System;

namespace Section_2._2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the number you want to calculate the factorial of.");
            var userInput = int.Parse(Console.ReadLine());
            int result = 1;
            for(int n = 1; n <= userInput; n++)
            {
                result *= n;
            }
            Console.WriteLine($"{userInput} factorial is {result}");
        }
    }
}
