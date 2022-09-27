using System;

namespace Principles_of_Programming
{
    class Program
    {
        static void Main()
        {
            Core core = new Core();
            

            while (true)
            {
                DisplayMenu();

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Add(core);
                        Console.ReadKey();
                        break;

                    case "2":
                        core.DisplayList();
                        Console.ReadKey();
                        break;

                    case "3":
                        RemoveByIndex(core);
                        Console.ReadKey();
                        break;

                    case "4":
                        core.RemoveFirst();
                        Console.ReadKey();
                        break;

                    case "5":
                        core.RemoveLast();
                        Console.ReadKey();
                        break;

                    case "6":
                        IncreaseCapacity(core);
                        Console.ReadKey();
                        break;
                }

                if (userChoice == "0")
                {
                    break;
                }


            }


        }

        private static void Add(Core core)
        {
            Console.WriteLine("Please enter first name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter last name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please enter student number");
            string studentNumber = Console.ReadLine();

            Console.WriteLine("Please enter student age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("How many diffirent scores would you like to enter?");
            int userInput = int.Parse(Console.ReadLine());
            int[] averageScores = new int[userInput];
            for (int i = 0; i < userInput; i++)
            {
            Console.WriteLine($"Please enter student score {i+1}");         
            averageScores[i] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("Please enter country");
            string country = Console.ReadLine();
            Console.WriteLine("Please enter city");
            string city = Console.ReadLine();
            Console.WriteLine("Please enter street");
            string street = Console.ReadLine();
            Console.WriteLine("Please enter rest of the address");
            string openAddress = Console.ReadLine();

            Address address = new Address (
                openAddress,
                street,
                city,
                country
                );
            
            Student newStudent = new Student
            (
                 firstName,
                 lastName,
                 studentNumber,
                 age,
                 averageScores,
                 address

            );

            core.Add(newStudent);
        }

        private static void RemoveByIndex(Core core)
        {
            Console.WriteLine("Please enter index");
            int index = int.Parse(Console.ReadLine());

            core.RemoveByIndex(index);
        }

        private static void IncreaseCapacity(Core core)
        {
            Console.WriteLine("How many extra spaces to add?");
            int userInput = int.Parse(Console.ReadLine());

            core.IncreaseCapacity(userInput);
        }

        private static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Display List");
            Console.WriteLine("3. Remove By Index");
            Console.WriteLine("4. Remove First");
            Console.WriteLine("5. Remove Last");
            Console.WriteLine("6. Increase Capacity");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Please enter your choice");

        }
    }
}
