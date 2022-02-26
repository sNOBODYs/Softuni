using System;

namespace Nested_loops_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());



            for (int i = 1; i <= 9; i++)

            {

                for (int a = 1; a <= 9; a++)

                {

                    for (int b = 1; b <= 9; b++)

                    {

                        for (int c = 1; c <= 9; c++)

                        {

                            if (n % i == 0 && n % a == 0 && n % b == 0 && n % c == 0)

                            {

                                Console.Write("{0}{1}{2}{3} ", i, a, b, c);

                            }

                        }

                    }

                }

            }

        }

    }

}
        
    

