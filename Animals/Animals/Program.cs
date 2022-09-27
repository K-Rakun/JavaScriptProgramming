using System;

namespace Animals
{
    class Program
    {
        static void Main()
        {
            int option;
            Console.WriteLine("Welcome to my game \n" +
                "In this game you will live your days with your animals \n" +
                "You have a cat what is her name?");
            
            Cat cat = new Cat(Console.ReadLine(), "Player");

            Console.WriteLine("How much do you like animals? \n" +
                "\n" +
                "Select one of the options.\n" +
                "1-A lot\n" +
                "2-A looooooooooot");
            option = int.Parse(Console.ReadLine());

            if(option == 1)
            {Console.WriteLine("Since you like animals a lot you decided to buy a dog as well");}
            else 
            {Console.WriteLine("Since you like animals a looooooooooot you decided to buy a dog as well"); }
            Console.WriteLine("What is his name?");
            Dog dog = new Dog(Console.ReadLine(), "Player");

            Console.WriteLine($"You got {dog.Name} and went back home.\n" +
                $"It is time for him to meet {cat.Name}.\n" +
                $"As soon as they saw each other they started fighting!\n" +
                $"What do you do?\n" +
                $"\n" +
                $"Select one of the options.\n" +
                $"1-Try to stop them\n" +
                $"2-Just watch");
            option = int.Parse(Console.ReadLine());

            if(option == 2)
            { Console.WriteLine("You watched them for a while and felt like a monster before stopping them"); }








        }
    }
}
