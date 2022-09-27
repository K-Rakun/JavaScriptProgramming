using System;

namespace Principles_of_Programming
{
    public class Core
    {
        private const int DefaultPlacesCount = 5;
        private int usedPlaces;
        private Student[] studentList;

        public Core() : this(DefaultPlacesCount)
        { }

        public Core(int placesCount)
        {
            studentList = new Student[placesCount];
            usedPlaces = 0;
        }

        public void Add(Student newStudent)
        {
            if (usedPlaces >= studentList.Length)
            {
                Console.WriteLine("List is full.");
            }
            else
            {
                studentList[usedPlaces] = newStudent;
                usedPlaces++;
                Console.WriteLine("New element added");
            }

        }

        public void RemoveByIndex(int index)
        {
            if (index < 0 || index >= usedPlaces)
            {
                Console.WriteLine("Invalid index: " + index);
            }

            else
            {
                for (int i = index; i < usedPlaces - 1; i++)
                {
                    studentList[i] = studentList[i + 1];
                }

                studentList[usedPlaces - 1] = null;
                usedPlaces--;
                Console.WriteLine("Chosen element removed");
            }
        }


        public void RemoveFirst()
        {
            if (usedPlaces == 0)
            {
                Console.WriteLine("List empty");
            }
            else
            {
                for (int i = 0; i < usedPlaces - 1; i++)
                {
                    studentList[i] = studentList[i + 1];
                }

                studentList[usedPlaces - 1] = null;
                usedPlaces--;
                Console.WriteLine("First element removed");
            }
        }
        public void RemoveLast()
        {
            if (usedPlaces == 0)
            {
                Console.WriteLine("List empty");

            }
            else
            {
                studentList[usedPlaces - 1] = null;
                usedPlaces--;
                Console.WriteLine("Last element removed");
            }
        }

        public void DisplayList()
        {
            Console.Clear();

            for (int i = 0; i < studentList.Length; i++)
            {
                if (studentList[i] == null)
                {
                    Console.WriteLine("n/a");
                }
                else
                {
                    Console.WriteLine(studentList[i]);
                }
            }
        }

        public void IncreaseCapacity(int userInput)
        {
            if (userInput <= 0)
            {
                Console.WriteLine("Please input a positive number");
            }
            else
            {
                Student[] resizedArray = new Student[studentList.Length + userInput];

                Array.Copy(studentList, 0, resizedArray, 0, studentList.Length);

                studentList = resizedArray;
                Console.WriteLine("Capacity increased");
            }
        }
    }
}
