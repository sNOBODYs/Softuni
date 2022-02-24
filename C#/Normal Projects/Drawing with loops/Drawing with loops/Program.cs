using System;

namespace Drawing_with_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            
            for (int i = 0; i < num; i++)
            {
                Console.Write(new string(' ', (num - 1) - i));
                Console.Write("*");

                for (int j = 0; j < i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

            
            for (int i = 0; i < num - 1; i++)
            {
                Console.Write(new string(' ', 1 + i));
                Console.Write("*");

                for (int j = 0; j < num - 2 - i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
    

