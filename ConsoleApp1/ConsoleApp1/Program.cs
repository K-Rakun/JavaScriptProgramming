using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("enter number");

            int a = int.Parse(Console.ReadLine());

            if (a > 10)
            {
                Console.WriteLine("Your number is higher than 10");
            }

            else
            {
                if (a == 10) 
                {
                    Console.WriteLine("Your number is equel to 10");
                }
                else
                {
                    Console.WriteLine("Your number is lower than 10");
                }

            }
        }
    }
}
