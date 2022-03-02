using System;

namespace Кола
{
    class Program
    {
        static void Main(string[] args)
        {
            double pari = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string classK = "";
            string vidK = "";

            if (pari <= 100)
            {
                classK = "Economy class";
                switch (season)
                {
                    case "Summer":
                        pari = pari * 0.35;
                        vidK = "Cabrio";
                        break;
                    case "Winter":
                        pari = pari * 0.65;
                        vidK = "Jeep";
                        break;
                }

            }
            else if (pari >= 100 && pari <= 500)
            {
                classK = "Compact class";
                switch (season)
                {
                    case "Summer":
                        pari = pari * 0.45;
                        vidK = "Cabrio";
                        break;
                    case "Winter":
                        pari = pari * 0.80;
                        vidK = "Jeep";
                        break;
                }
            }
            else if (pari > 500)
            {
                classK = "Luxury class";
                switch (season)
                {
                    case "Summer":
                    case "Winter":
                        pari = pari * 0.9;
                        vidK = "Jeep";
                        break;
                }
            }

            Console.WriteLine($"{classK}");
            Console.WriteLine($"{vidK} - {pari:f2}");

        }
    }
}