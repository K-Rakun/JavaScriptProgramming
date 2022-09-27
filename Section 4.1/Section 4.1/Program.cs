using System;

namespace Section_4._1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter your email.");

            string usersEmail = Console.ReadLine();

           
            bool ValidEmail = IsEmailValid(usersEmail);

            if (ValidEmail == true)
            {
                Console.WriteLine("Thank you for entering a valid email address.");
            }
            else
            {
                Console.WriteLine("Your email address is invalid.");
            }
        }
        static bool IsEmailValid(string email)
        {
            try
            {
                var address = new System.Net.Mail.MailAddress(email);
                return address.Address == email;
            }
            catch
            {
                return false;
            }
        }

    }
}
