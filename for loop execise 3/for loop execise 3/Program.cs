using System;

namespace for_loop_execise_3
{
    class Program
    {
        static void Main()
        {
            int i, sum = 0;


            Console.WriteLine("Input a value");

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"First {n} natural numbers");

            for (i = 1; i <= n; i++)
            {

                Console.Write($"{i} ");
                sum += i;

            }

            Console.WriteLine($"Sum of natural numbers upto {n} is {sum}");

        }
    }
}
