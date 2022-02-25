using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IBAN_regex
{
    class Program
    {
        static void Main(string[] args)
        {
            string iban = Console.ReadLine();
            if (CheckIBAN(iban))
            {
                Console.WriteLine("IBAN is in correct format");
            }
            else
            {
                Console.WriteLine("IBAN is not in correct format.");
            }
        }
        static bool CheckIBAN(string iban)
        {
            int lenght = iban.Length;
            if (lenght == 22)
            {
                string pattern = @"^BG[0-9A-Z]+$";
                Regex regex = new Regex(pattern);

                if (regex.IsMatch(iban))
                {
                    string substring = iban.Substring(0, 1);
                    string substring3 = iban.Substring(2, 3);
                    int substring3INT = int.Parse(substring3);
                    if (98 - substring3INT % 97 != substring3 )
                    {

                    }
                    string substring2 = iban.Substring(4);
                    iban.Insert(iban.Length - 1, substring + substring3);
                    for (int i = 0; i <= 3; i++)
                    {
                        iban.Remove(iban[i]);
                    }
                    StringBuilder something = new StringBuilder();
                    foreach (char item in substring2)
                    {
                        if (char.IsDigit(item))
                        {
                            something.Append(item);
                        }
                        else
                        {
                            something.Append(item - 'A' + 10);
                        }
                    }
                   
                    BigInteger smt = BigInteger.Parse(something.ToString());
                    if (smt % 97 != 1)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                    
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
