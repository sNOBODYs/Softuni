using System;

namespace Борса
{
    class Program
    {
        static void Main(string[] args)
        {
            double cenaZ = double.Parse(Console.ReadLine());
            double cenaP = double.Parse(Console.ReadLine());
            int kgZ = int.Parse(Console.ReadLine());
            int kgP = int.Parse(Console.ReadLine());

            double prZ = kgZ * cenaZ;
            double prP = kgP * cenaP;
            double prihod = (prZ + prP) / 1.94;

            Console.WriteLine ($"{prihod:f2}");

           


        }
    }
}
