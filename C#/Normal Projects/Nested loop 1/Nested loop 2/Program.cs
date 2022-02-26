using System;

namespace Nested_loop_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            for (int i = s; i <= b; i++)
            {
                
                string num = i.ToString();
                int length = num.Length;

                int evenSum = 0;
                int oddSum = 0;
                int k = i;


                for (int a = 0; a < length; a++)
                {
                    
                    int modul = k % 10;

                    
                    if ((a + 1) % 2 == 0)
                    {
                        evenSum += modul;
                    }
                    else
                    {
                        oddSum += modul;
                    }

                    k = (k - modul) / 10;
                }

                if (oddSum == evenSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
