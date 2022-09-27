using System;

namespace For_loop_exercise_37
{
    class Program
    {
        static void Main()
        {


            Console.WriteLine("Enter a number");

            int num = int.Parse(Console.ReadLine());
            int r;
            int sum = 0;

            for ( ; num > 0; num = num / 10)
            {
                r = num % 10;

                sum = (sum * 10) + r;

            }
            Console.WriteLine("sum");
            Console.WriteLine(sum);
        }
    }
}
