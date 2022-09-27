using System;

namespace Calculater
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Chose one.\n" +
                "1- Plus\n" +
                "2- Minus\n" +
                "3- Multipication\n" +
                "4- Divide\n" +
                "0- Exit");
            var input = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = int.Parse(Console.ReadLine());

            int result;
            
            
            if (input == 1)
            {
                result = num1 + num2;
                Console.WriteLine(result);
            }
            else if (input == 2)
            {
                result = num1 - num2;
                Console.WriteLine(result);
            }
            else if (input == 3)
            {
                result = num1 * num2;
                Console.WriteLine(result);
            }
            else if (input == 4)
            {
                try 
                {
                    result = num1 / num2;
                    Console.WriteLine(result);
                }

                catch(DivideByZeroException)
                {
                    Console.WriteLine("Can't divide by 0");
                }
                
               
            }
        }

        

        
    }
}
