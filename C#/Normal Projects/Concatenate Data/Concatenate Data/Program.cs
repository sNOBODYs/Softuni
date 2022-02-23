using System;

namespace Concatenate_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();
            Console.WriteLine($"You are {FirstName} {lastName}, a {age}-years old person from {town}.");
        }
    }
}
