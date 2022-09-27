using System;

namespace Section_4._2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a sentence.");

            string sentence = Console.ReadLine();
            string[] words = sentence.Split();

            foreach(var word in words)
            {
                string capitalizedWord = CapitalizeWord(word);
                Console.Write(capitalizedWord+" ");
            }
        }
        static string CapitalizeWord(string word)
        {
            return char.ToUpper(word[0]) + word[1..];
        }
    }
}
