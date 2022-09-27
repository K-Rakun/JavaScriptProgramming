using System;
using System.Linq;

namespace Section_3._2
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Select one.\n" +
                "1 - Number array\n" +
                "2 - String array");
            int selection = int.Parse(Console.ReadLine());

            if (selection == 1)
            {
                Console.WriteLine("How many numbers is there in your array?");
                float[] numbers = new float[int.Parse(Console.ReadLine())];

                Console.WriteLine("Enter your numbers one by one.");
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = float.Parse(Console.ReadLine());
                }
                
                numbers = numbers.Distinct().ToArray();

                Console.WriteLine("Your array without duplicates");
                for(int i = 0;i < numbers.Length; i++)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            else
            {
                Console.WriteLine("How many words is there in your array?");
                string[] words = new string[int.Parse(Console.ReadLine())];

                Console.WriteLine("Enter your words one by one.");
                for (int i = 0; i < words.Length; i++)
                {
                    words[i] = Console.ReadLine();
                }
                words = words.Distinct().ToArray();

                Console.WriteLine("Your array without duplicates");
                for (int i = 0; i < words.Length; i++)
                {
                    Console.WriteLine(words[i]);
                }
            }

                
        }
    }
}
