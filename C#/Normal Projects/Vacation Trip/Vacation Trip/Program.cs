using System;

namespace Vacation_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string destinationResult = string.Empty;
            string holidayInformation = string.Empty;
            var moneySpent = 0.00M;

            if (budget <= 100)
            {
                //winter 

                destinationResult = "Bulgaria";    
                moneySpent = 0.70M * budget;
                holidayInformation = string.Format($"Hotel - {moneySpent:F2}");
                if (season.Equals("summer"))
                {
                    moneySpent = 0.30M * budget;
                    holidayInformation = string.Format($"Camp - {moneySpent:F2}");
                }
                Console.WriteLine($"Somewhere in {destinationResult}");
                Console.WriteLine(holidayInformation);

            }
            else if (budget <= 1000)
            {
                destinationResult = "Balkans";
                moneySpent = 0.80M * budget;
                holidayInformation = string.Format($"Hotel - {moneySpent:F2}");
                if (season.Equals("summer"))
                {
                    moneySpent = 0.40M * budget;
                    holidayInformation = string.Format($"Camp - {moneySpent:F2}");
                }
                Console.WriteLine($"Somewhere in {destinationResult}");
                Console.WriteLine(holidayInformation);

            }
            else
            {
                destinationResult = "Europe";
                moneySpent = 0.90M * budget;
                holidayInformation = string.Format($"Hotel - {moneySpent:F2}");
                Console.WriteLine($"Somewhere in {destinationResult}");
                Console.WriteLine(holidayInformation);
            }




        }
    }
}