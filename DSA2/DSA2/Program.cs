using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA2
{
    class Program
    {
        static void Main()
        {

            //Capitalise();

            //Cut();

            Lists();

            /*double a = 183837474.08837000002;
            double b = 7373.0000056;
            double x1 = a / b * Math.PI;
            double x2 = a * Math.PI / b;
            if (x1 == x2) System.Console.WriteLine("equal");
            else System.Console.WriteLine("not equal");
            if (Math.Abs(x1 - x2) < 0.0001) System.Console.WriteLine("almost equal");
            System.Console.ReadLine();*/

        }

        static void Capitalise()
        {
            string sentence = "this is a chapter title";
            String[] words = sentence.Split(' ');
            foreach(var word in words)
            {
                Console.Write(char.ToUpper(word[0]) + word.Substring(1));
            }
        }

        static void Cut()
        {
            string sentence = "There is a bug (with 8 legs) in the database table.";
            string[] words = sentence.Split(' ');
            string result = "";
            foreach(var word in words)
            {
                if (result.Length < 18)
                {
                    result = result + word + " ";
                }
            }
            string[] final = result.Split(' ');
        }

        static void Lists()
        {
            
            List<int> ll = new List<int>();
            ll.Add(1);
            ll.Add(2);
            ll.Add(-1);
            ll.Add(3);

            for (int i = ll.Count - 1; i >= 0; i--)
            {
                if(ll[i] < 0)
                {
                    ll.RemoveAt(i);
                }
            }

            Console.WriteLine(ll);
            
        }
    }
}
