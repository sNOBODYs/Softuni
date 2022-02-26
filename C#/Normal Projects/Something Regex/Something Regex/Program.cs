using System;
using System.Text.RegularExpressions;

namespace Something_Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%([A-Z][a-z]+)%<([A-Z][a-z]+)>\|(\d+)\|(\d+\.?\d*)\$";
            double totalIncome = 0;

            while (true)
            {
                var line = Console.ReadLine();

                if (line == "end of shift")
                {
                    break;
                }

                if (Regex.IsMatch(line, pattern))
                {
                    Match match = Regex.Match(line, pattern);
                    var customer = match.Groups[1].Value;
                    string product = match.Groups[2].Value;
                    int count = int.Parse(match.Groups[3].Value);
                    double price = double.Parse(match.Groups[4].Value);
                    double money = price * count;
                    Console.WriteLine($"{customer}: {product} - {money:F2}");
                    totalIncome += money;
                }
            }
            Console.WriteLine($"Total income: {totalIncome:F2}");
        
        }
    }
}
