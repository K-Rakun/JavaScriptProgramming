namespace Principles_of_Programming
{
    public class Student : Person
    {
        public Student(string firstName, string lastName, string studentNumber, int age, int[] scores, Address address)
        {
            FirstName = firstName;
            LastName = lastName;
            StudentNumber = studentNumber;
            Age = age;
            Scores = scores;
            Address = address;
        }
        public string StudentNumber { get; set; }
        public int Age { get; set; }
        
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
            set
            {
                
            }
        }
        public int[] Scores { get; set; }
        public int averageScore;
        public int AverageScores
        {
            get
            {
                int total = 0;
                for (int i = 0; i < Scores.Length; i++)
                {
                    total += Scores[i];
                }
                averageScore = total / Scores.Length;
                return averageScore;
            }
            set
            {
                
            }
        }

        public Address Address { get; set; }
       
        public string FullAddress
        {
            get
            {
                return $"{Address.OpenAddress} {Address.Street} {Address.City} {Address.Country}";
            }
            set
            {
                
            }
        }
        public override string ToString()
        {
            return $"Student {FullName}'s average score is {AverageScores}\n" +
                $"Student {FullName} is living in {Address.City}\n" +
                $"Student {FullName}'s address is {FullAddress}\n" +
                $"Student {FullName}'s number is {StudentNumber}\n" +
                $"Student {FullName}'s age is {Age}\n";
        }
    }
}
