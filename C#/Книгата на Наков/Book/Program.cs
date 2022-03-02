using System;
using System.Text;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello. I'm [from] Pravets.I'm C# [developer].";
            Console.WriteLine(Capitals(text));
        }
        static string Capitals(string text)
        {
            StringBuilder sdr = new StringBuilder();
            bool isCapital = false;

            foreach (string symbol in text)
            {
                if (symbol == "<upcase>")
                {
                    isCapital = true;
                }
                else if (symbol == "</upcase>")
                {
                    isCapital = false;
                }
                else
                {
                    if (isCapital)
                    {
                        sdr.Append(char.ToUpper(symbol));
                    }
                    else
                    {
                        sdr.Append(symbol);
                    }
                }
            }
            
            return sdr.ToString() ;
        }
    }
}
