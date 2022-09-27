using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDataList
{
    public class Student
    {
        public Student(string firstName, string lastName, string studentNumber, float averageScore)
        {
            FirstName = firstName;
            LastName = lastName;
            StudentNumber = studentNumber;
            AverageScore = averageScore;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string StudentNumber { get; set; }

        public float AverageScore { get; set; }

        public override string ToString()
        {
            return $"First Name: {FirstName}, Last Name: {LastName}, Student Number: {StudentNumber}, Average Score: {AverageScore}";
        }

    }
}
