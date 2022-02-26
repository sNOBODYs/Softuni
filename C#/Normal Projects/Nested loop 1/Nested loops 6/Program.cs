using System;

namespace Nested_loops_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());                                                           
            int l = int.Parse(Console.ReadLine());

            for (int a = 1; a < n; a++)
            {
                for (int b = 1; b < n; b++)
                {
                    for (int c = 'a'; c < 'a' + n; c++)
                    {
                        for (int d = 'a'; d < 'a' + n; d++)
                        {
                            for (int e = 2; e <= n; e++)
                            {

                                if (e > a && e > b)
                                {
                                    Console.Write($"{a}{b}{(char)c}{(char)d}{e} ");
                                }


                            }
                        }
                    }
                }
            }
        }
    }
}
