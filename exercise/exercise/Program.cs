using System;

namespace exercise
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Enter the first integer");

            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second integer");

            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Options");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Substraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Divison");
            Console.WriteLine("5 - Exit");
            Console.WriteLine("Input your choice");

            int choice = int.Parse(Console.ReadLine());


           


            switch (choice)
            {
                case 1:
                    Console.WriteLine($"{num1}+{num2} is {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"{num1}-{num2} is {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"{num1}*{num2} is {num1 * num2}");
                    break;
                case 4:
                    Console.WriteLine($"{num1}/{num2} is {num1 / num2}");
                    break;
                case 5:
                    break;

                default:
                    Console.WriteLine("Please input one of the options");
                    break;
            }




        }
    }
}
