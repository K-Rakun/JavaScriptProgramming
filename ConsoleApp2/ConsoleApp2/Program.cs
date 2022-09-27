using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("please enter 3 sides of the triangle");
            Console.Write("Side A :");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Side B :");
            int B = int.Parse(Console.ReadLine());
            Console.Write("Side C :");
            int C = int.Parse(Console.ReadLine());

            if (A == B && B == C)
            {
                Console.WriteLine("There are 3 equal sides");
            }
            else if (A == B || A == C || B == C)
            {
                Console.WriteLine("There are 2 equal sides");
            }
            else if (A != B && A != C && B != C)
            {
                Console.WriteLine("There are no equal sides");
            }



            if (A == B && B == C)
            {
                Console.WriteLine("All sides are equal");

            }
            else if (A == B )
            {
                Console.WriteLine("Side A and B is equal");
            }

            else if (A == C)
            {
                Console.WriteLine("Side A and C is equal");
            }
            else if (B == C)
            {
                Console.WriteLine("Side B and C is equal");
            }
            
        }
    }
}
