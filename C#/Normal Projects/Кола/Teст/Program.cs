using System;

namespace Teст
{
    class Program
    {
        static void Main(string[] args)
        {

            int Bees = int.Parse(Console.ReadLine());
            int healthB = int.Parse(Console.ReadLine());
            int attackB = int.Parse(Console.ReadLine());

            while (healthB >= 0 && Bees > 100)
            {

                Bees = Bees - attackB;
                healthB = healthB - Bees * 5;

                if (healthB <= 0)
                {
                    Console.WriteLine("Beehive won! Bees left " + Bees + ".");
                }
                if (Bees < 100)
                {
                    if (Bees < 0)
                    {
                        Console.WriteLine("The bear stole the honey! Bees left 0.");
                    }
                    else
                    {
                        Console.WriteLine("The bear stole the honey! Bees left " + Bees + ".");
                    }
                }
            }

        }


       
    }
}
