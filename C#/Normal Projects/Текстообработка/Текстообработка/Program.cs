using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Текстообработка
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string input = Console.ReadLine().ToLower();
            string partOf = Console.ReadLine().ToLower() ;
            int index = input.IndexOf(partOf);

            while (index != -1)
            {
                count++;
                index = input.IndexOf(partOf, index + 1);
            }
            Console.WriteLine(count);
               
            
        }
    }
}
