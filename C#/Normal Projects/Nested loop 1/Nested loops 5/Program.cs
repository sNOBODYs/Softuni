using System;

namespace Nested_loops_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            double sum = 0;
            double allSum = 0;
            double midleSum = 0;
            int counter = 0;
            string Prez = "";

            while (true)
            {
                Prez = Console.ReadLine();

                if (Prez == "Finish")
                {
                    break;
                }
                for (int i = 1; i <= num; i++)
                {
                    double evaluation = double.Parse(Console.ReadLine());
                    sum += evaluation;
                    allSum = sum / num;
                    counter++;
                }

                Console.WriteLine($"{Prez} - {allSum:f2}.");
                midleSum += sum;                   
                sum = 0;                          
            }
            midleSum /= counter;                
            Console.WriteLine($"Student's final assessment is {midleSum:f2}.");
        }
    }
}
