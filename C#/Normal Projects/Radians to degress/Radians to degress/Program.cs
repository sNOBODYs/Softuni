using System;

namespace Radians_to_degress
{
    class Program
    {
        static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());
            double gr = (2 * Math.PI) / 360;
            Console.WriteLine(Math.Round(gr));
        }
    }
}
