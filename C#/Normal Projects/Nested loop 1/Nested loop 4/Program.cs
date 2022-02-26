using System;

namespace Nested_loop_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            int SUMprime = 0;
            int NOprime = 0;

            while (num != "stop")
            {
                bool prime = true; 
                int n = int.Parse(num);
                if (n < 0)
                {
                    n = 0;
                    Console.WriteLine("Number is negative.");

                }

                else if (n == 1)
                {
                    prime = false;
                }
                else
                {
                    for (int count = 2; count <= n; count++)
                    {
                        if (n % count == 0 && count != n)

                        {
                            prime = false;

                            break;
                        }
                    }

                }
                if (prime)
                {
                    SUMprime += n;
                }
                else if (prime == false)
                {
                    NOprime += n;
                }
                num = Console.ReadLine();
            }
            if (num == "stop")
            {
                Console.WriteLine($"Sum of all prime numbers is: {SUMprime}");
                Console.WriteLine($"Sum of all non prime numbers is: {NOprime}");
            }
        }
    }  
}

