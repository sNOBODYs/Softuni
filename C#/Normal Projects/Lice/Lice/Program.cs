using System;

namespace Programirane_v_chas
{
    class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();

            if (shape == "triangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());

                double Sreg = sideA * sideB / 2;
                Console.WriteLine(Sreg);
            }
            else if (shape == "circle")
            {
                double r = double.Parse(Console.ReadLine());

                double Scir = r * r * Math.PI;
                Console.WriteLine(Scir);
            }
            else if (shape == "square")
            {
                double SideSA = double.Parse(Console.ReadLine());


                double Ssqu = SideSA * SideSA;
                Console.WriteLine(Ssqu);
            }
            else if (shape == "rectangle")
            {
                double sideArect = double.Parse(Console.ReadLine());
                double siedeBrect = double.Parse(Console.ReadLine());

                double Srect = sideArect * siedeBrect;
                Console.WriteLine(Srect);
            }






        }
    }
}

