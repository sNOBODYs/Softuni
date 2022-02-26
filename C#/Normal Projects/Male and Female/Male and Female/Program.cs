using System;

namespace Male_and_Female
{
    class Program
    {
        static void Main(string[] args)
        {
            string gender = Console.ReadLine();
            double age = double.Parse(Console.ReadLine());
            if (gender == "f")
            {
                
                if (age >= 16)
                {
                    Console.WriteLine("Ms.");
                }
                else
                {
                    Console.WriteLine("Miss.");
                }

            }
            else if (gender == "m") 
            {
                if (age >= 16)
                {
                    Console.WriteLine("Mr.");
                }
                else 
                {
                    Console.WriteLine("Master.");
                }

            }
        }
    }
}
