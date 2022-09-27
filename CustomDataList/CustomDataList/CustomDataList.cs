using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDataList
{
    class CustomDataList
    {

        private const int DefaultPlacesCount = 20;
        private int usedPlaces;
        private Student[] studentList;

        public CustomDataList() : this(DefaultPlacesCount)
        { }

        public CustomDataList(int placesCount)
        {
            studentList = new Student[placesCount];
            usedPlaces = 0;
        }

        public void PopulateWithSampleData()
        {
            Random rnd = new Random();

            for (int i = usedPlaces; i < studentList.Length; i++)
            {
                studentList[i] = new Student
                (
                    $"first name {i}",
                    $"last name {i}",
                    $"{rnd.Next(1, 1000)}",
                    rnd.Next(1, 100)
                );

                usedPlaces++;
            }
            Console.WriteLine("List filled");
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

        public Student GetElement(int index)
        {
            if (index < 0 || index >= usedPlaces)
            {
                Console.WriteLine("Invalid index: " + index);
                return null;
            }

            else
            {
                Student getElement = studentList[index];
                for (int i = index; i < usedPlaces - 1; i++)
                {
                    studentList[i] = studentList[i + 1];
                }

                studentList[usedPlaces - 1] = null;
                usedPlaces--;
                Console.WriteLine($"You are holding {getElement}");
                return getElement;

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

        public void SortByAverageScore()
        {
            Student[] sortedArrey = new Student[studentList.Length];
            int fakeUsedPlaces = usedPlaces;
            for (int i = 0; i < usedPlaces; i++)
            {
                int n = 0;
                Student getElement = studentList[0];
                for (int t = 0; t < fakeUsedPlaces; t++)
                {
                    if (getElement.AverageScore < studentList[t].AverageScore)
                    {
                        getElement = studentList[t];
                        n = t;
                    }
                }

                for (int t = n; t < fakeUsedPlaces - 1; t++)
                {
                    studentList[t] = studentList[t + 1];
                }

                studentList[fakeUsedPlaces - 1] = null;
                fakeUsedPlaces--;
                
                sortedArrey[i] = getElement;
            }
            studentList = sortedArrey;
            Console.WriteLine("Sorted By Average Score");
        }

        public Student GetMaxElement()
        {
            int n = 0;
            Student getElement = studentList[0];
            for (int i = 0; i < usedPlaces ; i++)
            {
                if (getElement.AverageScore < studentList[i].AverageScore)
                {
                    getElement = studentList[i];
                    n = i;
                }
            }

            for (int i = n ; i < usedPlaces - 1; i++)
            {
                studentList[i] = studentList[i + 1];
            }

            studentList[usedPlaces - 1] = null;
            usedPlaces--;
            Console.WriteLine($"You are holding {getElement}");
            return getElement;
            
        }

        public Student GetMinElement()
        {
            int n = 0;
            Student getElement = studentList[0];
            for (int i = 0; i < usedPlaces; i++)
            {
                if (getElement.AverageScore > studentList[i].AverageScore)
                {
                    getElement = studentList[i];
                    n = i;
                }
            }

            for (int i = n; i < usedPlaces - 1; i++)
            {
                studentList[i] = studentList[i + 1];
            }

            studentList[usedPlaces - 1] = null;
            usedPlaces--;
            Console.WriteLine($"You are holding {getElement}");
            return getElement;

        }

    }
}
