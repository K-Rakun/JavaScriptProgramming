using System;

namespace Section_2._1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("How many numbers you want to compare?\n" +
                "1-Compare 2 Numbers\n" +
                "2-Compare 4 Numbers\n" +
                "0-Exit");
            var userInput = int.Parse(Console.ReadLine());
            int num1;
            int num2;
            int num3;
            int num4;

            if (userInput == 1)
            {
                Console.WriteLine("Enter your first number.");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your second number.");
                num2 = int.Parse(Console.ReadLine());
                if (num1 > num2)
                { Console.WriteLine($"\n{num1} is bigger."); }
                else if (num2 > num1) 
                { Console.WriteLine($"\n{num2} is bigger."); }
                else { Console.WriteLine($"\n{num1} is equel to {num2}."); }
            }

            else if (userInput == 2)
            {
                Console.WriteLine("Enter your first number.");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your second number.");
                num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your third number.");
                num3 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your forth number.");
                num4 = int.Parse(Console.ReadLine());
                if (num1 > num2 && num1 > num3 && num1 > num4) 
                { Console.WriteLine($"\n{num1} is the biggest."); }
                else if (num2 > num1 && num2 > num3 && num2 > num4)
                { Console.WriteLine($"\n{num2} is the biggest."); }
                else if (num3 > num1 && num3 > num2 && num3 > num4)
                { Console.WriteLine($"\n{num3} is the biggest."); }
                else if (num4 > num1 && num4 > num2 && num4 > num3)
                { Console.WriteLine($"\n{num4} is the biggest."); }
                else 
                { Console.WriteLine("\nThey are all the same number."); }
            }

            Console.WriteLine("\nThank you for using this program.");

        }
    }
}
