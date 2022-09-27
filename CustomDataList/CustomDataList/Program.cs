using System;

namespace CustomDataList
{
    class Program
    {
        static void Main()
        {
            CustomDataList customDataList = new CustomDataList();

            while (true)
            {
                DisplayMenu();

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        customDataList.PopulateWithSampleData();
                        Console.ReadKey();
                        break;

                    case "2":
                        Add(customDataList);
                        Console.ReadKey();
                        break;

                    case "3":
                        GetElement(customDataList);
                        Console.ReadKey();
                        break;

                    case "4":
                        RemoveByIndex(customDataList);
                        Console.ReadKey();
                        break;

                    case "5":
                        customDataList.RemoveFirst();
                        Console.ReadKey();
                        break;

                    case "6":
                        customDataList.RemoveLast();
                        Console.ReadKey();
                        break;

                    case "7":
                        customDataList.DisplayList();
                        Console.ReadKey();
                        break;

                    case "8":
                        IncreaseCapacity(customDataList);
                        Console.ReadKey();
                        break;
                    case "9":
                        customDataList.SortByAverageScore();
                        Console.ReadKey();
                        break;
                    case "10":
                        customDataList.GetMaxElement();
                        Console.ReadKey();
                        break;
                    case "11":
                        customDataList.GetMinElement();
                        Console.ReadKey();
                        break;
                }

                if (userChoice == "0")
                {
                    break;
                }


            }


        }

        private static void Add(CustomDataList customDataList)
        {
            Console.WriteLine("Please enter first name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter last name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please enter student number");
            string studentNumber = Console.ReadLine();

            Console.WriteLine("Please enter average score");
            int averageScore = int.Parse(Console.ReadLine());

            Student newStudent = new Student
            (
                 firstName,
                 lastName,
                 studentNumber,
                 averageScore
            );

            customDataList.Add(newStudent);
        }

        private static void GetElement(CustomDataList customDataList)
        {
            Console.WriteLine("Please enter index");
            int index = int.Parse(Console.ReadLine());

            customDataList.GetElement(index);
        }

        private static void RemoveByIndex(CustomDataList customDataList)
        {
            Console.WriteLine("Please enter index");
            int index = int.Parse(Console.ReadLine());

            customDataList.RemoveByIndex(index);
        }

        private static void IncreaseCapacity(CustomDataList customDataList)
        {
            Console.WriteLine("How many extra spaces to add?");
            int userInput = int.Parse(Console.ReadLine());

            customDataList.IncreaseCapacity(userInput);
        }

        private static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Populate with sample data");
            Console.WriteLine("2. Add Element");
            Console.WriteLine("3. Get Element");
            Console.WriteLine("4. Remove By Index");
            Console.WriteLine("5. Remove First");
            Console.WriteLine("6. Remove Last");
            Console.WriteLine("7. Display List");
            Console.WriteLine("8. Increase Capacity");
            Console.WriteLine("9. Sort by Average Score");
            Console.WriteLine("10. Get Max Element");
            Console.WriteLine("11. Get Min Element");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Please enter your choice");

        }
    }
}

