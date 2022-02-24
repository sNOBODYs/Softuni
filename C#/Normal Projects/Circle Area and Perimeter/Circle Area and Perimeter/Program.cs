using System;

namespace Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {

            var r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;
            double per = 2 * Math.PI * r;
            Console.WriteLine("{0:F4}",area);
            Console.WriteLine("{0:F4}",per);
        }
    }
}
