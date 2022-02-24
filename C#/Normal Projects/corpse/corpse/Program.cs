using System;

namespace Cropse
{
    class Program
    {
        static void Main(string[] args)
        {
            double gardenS = double.Parse(Console.ReadLine());
            double grapesP = double.Parse(Console.ReadLine());
            double L = double.Parse(Console.ReadLine());
            double rabotnici = double.Parse(Console.ReadLine());

            double grapeS = grapesP * (gardenS * 0.40);
            double litres = grapeS / 2.5;

            if (litres > L)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(litres)} liters.");
                Console.WriteLine($"{Math.Ceiling(litres - L)} liters left -> {Math.Ceiling((litres -L) / rabotnici)} liters per person.");
            }
            else if (litres < L)
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(L - litres)} liters wine needed.");
        }
    }
}