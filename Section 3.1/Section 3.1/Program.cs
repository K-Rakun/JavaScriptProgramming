using System;
using System.Linq;

namespace Section_3._1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("How many numbers is there in your array?");
            float[] numbers = new float[int.Parse(Console.ReadLine())];

            Console.WriteLine("Enter your numbers one by one.");
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = float.Parse(Console.ReadLine());
            }

            float max = numbers.Max();
            float min = numbers.Min();
            float sum = numbers.Sum();
            float average = sum / numbers.Length;



            Console.WriteLine($"Max = {max}\n" +
                $"Min = {min}\n" +
                $"Sum = {sum}\n" +
                $"Average = {average}");
        }
    }
}
