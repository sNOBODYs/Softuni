using System;

namespace Nested_loop_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2= int.Parse(Console.ReadLine());

            for (int a = num1; a <= num2; a++)
            {
                int lsum = 0;
                int Rsum = 0;
                int Msum = 0;

                int dig5 = a % 10; 
                int dig4 = (a / 10) % 10; 
                int dig3 = (a / 100) % 10; 
                int dig2 = (a / 1000) % 10; 
                int dig1 = (a / 10000) % 10; 

                lsum = dig1 + dig2;
                Rsum = dig4 + dig5;
                Msum = dig3;

                if (lsum == Rsum)
                {
                    Console.Write(a + " ");
                }

                else if (lsum > Rsum)
                {
                    int NewRsum = Rsum + Msum;
                    if (lsum == NewRsum)
                    {
                        Console.Write(a + " ");
                    }
                }

                else if (Rsum > lsum)
                {
                    int NewLsum = lsum + Msum;
                    if (Rsum == NewLsum)
                    {
                        Console.Write(a + " ");
                    }
                }
            }

        }
    }
}
    

