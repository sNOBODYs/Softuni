using System;

namespace Father
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double boqc;
            double boqb;

                double ploshtPrednaStena = (a * a) - (1.2 * 2);
                double ploshtDqsnaLqvaStrana = 2 * ((a * b) - (1.5 * 1.5));
                double ploshtZadnaStena = a * a;
                double ploshtPokkriv = 2 * ((a * h) / 2 + (a * b));


            boqc = (ploshtPrednaStena + ploshtZadnaStena + ploshtDqsnaLqvaStrana) / 3.4;
            boqb = ploshtPokkriv / 4.3;

                Console.WriteLine($"{boqc:f2}");
                Console.WriteLine($"{boqb:f2}");
            }
        }
    }


