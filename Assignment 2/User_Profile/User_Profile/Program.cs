// See https://aka.ms/new-console-template for more information
using System;

namespace UserProfile
{
    class Program
    {
        static void Main(string[] args)
        {
    
            string name;
            string email;
            string phoneNumber;

     
            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Enter your email: ");
            email = Console.ReadLine();

           
            Console.Write("Enter your phone number: ");
            phoneNumber = Console.ReadLine();

         
            Console.WriteLine("\nUser Profile:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Phone Number: {phoneNumber}");

            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

