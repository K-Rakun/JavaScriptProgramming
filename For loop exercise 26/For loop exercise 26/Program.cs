using System;

namespace For_loop_exercise_26
{
    class Program
    {
        static void Main()
        {

            int i, sum = 0;
           
            Console.WriteLine("Input a value");

            int n = int.Parse(Console.ReadLine());

            int a = 1;

            for (i = 1; i <= n; i++)
            {
                Console.Write($"{a} + ");
                sum = sum + a;
                a = (a * 10) + 1;
            }
            Console.WriteLine($"The sum is {sum}");
        }
    }
}
