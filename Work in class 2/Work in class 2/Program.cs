using System;

namespace Work_in_class_2
{
    class Program
    {
        static void Main()
        {  
            int Select;
            do
            {
                Console.Clear();
                Console.WriteLine("Select one\n" +
                "1-Number Check\n" +
                "2-H4ck3r 5p34k\n" +
                "0-Exit");


                Select = int.Parse(Console.ReadLine());
               
                switch (Select)
                {
                    case 1:
                        NumberCheck();
                        break;
                    case 2:
                        HackerSpeak();
                        break;
                }
                




            } while (Select != 0);




        }

        private static void NumberCheck()
        {
            Console.Clear();
            Console.WriteLine("Enter a number");
            var num = int.Parse(Console.ReadLine());

            int[] numbers = { 23, 2, 3, 6, 32, 65, 33, 45, 343, 34, 87, 99 };

            bool inArrey = false;

            foreach (int number in numbers)
            {
                if (num == number)
                {
                    inArrey = true;
                }
            }

            if (inArrey)
            {
                Console.WriteLine($"{num} is there");
            }
            else
            {
                Console.WriteLine($"{num} is NOT there");

            }
            Console.WriteLine("Press any button to continue");
            Console.ReadKey();
        }

        private static void HackerSpeak()
        {
            Console.Clear();
            Console.WriteLine("Enter a sentence");
            string original = Console.ReadLine();


            original = original.Replace("a", "4");
            original = original.Replace("e", "3");
            original = original.Replace("i", "1");
            original = original.Replace("o", "0");
            original = original.Replace("s", "5");
            original = original.Replace("A", "4");
            original = original.Replace("E", "3");
            original = original.Replace("I", "1");
            original = original.Replace("O", "0");
            original = original.Replace("S", "5");


            Console.WriteLine(original);
            Console.WriteLine("Press any button to continue");
            Console.ReadKey();
        }

    }
}
