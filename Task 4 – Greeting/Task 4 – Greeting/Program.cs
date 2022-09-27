using System;

namespace Task_4___Greeting
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Please enter the day of the week");

            int day = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the hour");

            int hour = int.Parse(Console.ReadLine());



            string A= "sasasasas";



            if (hour < 5 && hour <= 12)
            {
                 A = "morning";
            }

            if (hour < 12 && hour <= 18)
            {
                 A = "afternoon";
            }

            if (hour < 18 && hour <= 23)
            {
                 A = "evening";
            }

            if (hour <= 5 && hour < 23)
            {
                 A = "night";
            }







            switch (day)
            {
                case 1: Console.WriteLine($"Good {A}, it is a lovely Monday today. Weekend is coming in 5 days"); break;
                case 2: Console.WriteLine($"Good {A}, it is a lovely Tuesday today. Weekend is coming in 4 days"); break;
                case 3: Console.WriteLine($"Good {A}, it is a lovely Wednesday today. Weekend is coming in 3 days"); break;
                case 4: Console.WriteLine($"Good {A}, it is a lovely Thursday today. Weekend is coming in 2 days"); break;
                case 5: Console.WriteLine($"Good {A}, it is a lovely Friday today. Weekend is coming in 1 day"); break;
                case 6: Console.WriteLine($"Good {A}, it is a lovely Saturday today. Weekend is here"); break;
                case 7: Console.WriteLine($"Good {A}, it is a lovely Sunday today. Weekend is here"); break;
                default: Console.WriteLine("Error!"); break;
            }










        }
    }
}
