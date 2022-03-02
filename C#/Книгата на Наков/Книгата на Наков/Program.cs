using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Книгата_на_Наков
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Option 1 : A question");
            Console.WriteLine("Option 2 : Reverse text");
            Console.WriteLine("Option 3 : Brackets");
            Console.WriteLine("Option 4 : A question");
            Console.WriteLine("Option 5 : Counter on specific word");
            Console.WriteLine("Option 6 : Capitals");                           
            Console.WriteLine("Option 7 : Stars");                           
            Console.WriteLine("Option 8 : Under maintence");
            Console.WriteLine("Option 9 : Under maintence");                      
            Console.WriteLine("Option 10: Whole sentence");
            Console.WriteLine("Option 11: Banned word");
            Console.WriteLine("Option 12: 15 intervals");
            Console.WriteLine("Option 13: Email braker");
            Console.WriteLine("Option 14: Yoda senese");
            Console.WriteLine("Option 15: Data for dumies");
            Console.WriteLine("Option 16: Edit format");
            Console.WriteLine("Option 17: Math date");
            Console.WriteLine("Option 18: Math date 2.0");
            Console.WriteLine("Option 19: Email");                                    
            Console.WriteLine("Option 20: Date taker");                                   
            Console.WriteLine("Option 21: Palindromi");                                  
            Console.WriteLine("Option 22: HowMuchChars");                                
            Console.WriteLine("Option 23: Under maintence");
            Console.WriteLine("Option 24: Same Letters");
            Console.WriteLine("Option 25: Alphabedical order");
            Console.WriteLine("Option 26: Under maintence");
            Console.WriteLine();
            int option;
            int.TryParse(Console.ReadLine(), out option);

            switch (option)
            {
                case 1:
                    
                    break;
                case 2:
                   ReverseText();
                    break;
                case 3:
                   Brakets();
                    break;
                case 4:
                    
                    break;
                case 5:
                     Counter();
                    break;
                case 6:
                    Capitals();
                    break;
                case 7:
                    Starts();
                    break;
                case 8:
                    
                    break;
                case 9:
                    
                    break;
                case 10:
                    WholeSentence();
                    break;
                case 11:
                    BadWord();
                    break;
                case 12:
                    FifteenIntervals();
                    break;
                case 13:
                   HTTP();
                    break;
                case 14:
                    YodaSense();
                    break;
                case 15:
                    DattaForDummies();
                    break;
                case 16:
                     HTMLedit();
                    break;
                case 17:
                    MathDate();
                    break;
                case 18:
                    MathDateSecondForm();
                    break;
                case 19:
                    Email();
                    break;
                case 20:
                    DateTaker();
                    break;
                case 21:
                    Palindromi();
                    break;
                case 22:
                    HowMuchChars();
                    break;
                case 23:
                    HowMuchWords();
                    break;
                case 24:
                    SameLetters();
                    break;
                case 25:
                    AlphabeticalOrder();
                    break;
                case 26:
                    break;
                



            }
                                                                                           // Zad 2
            static void ReverseText()
            {
                Console.Write("Write a word : ");
                string word = Console.ReadLine();
                Console.WriteLine();



                StringBuilder something = new StringBuilder();
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    something.Append(word[i]);
                }
                Console.WriteLine($"{word} = {something}");
            }

                                                                                             // Zad 3
            static void Brakets()
            {
                Console.Write("Enter something with Brakets:");
                string text = Console.ReadLine();
                Console.WriteLine();
                int count = 0;


                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == '(')
                    {
                        count++;
                    }
                    else
                    {
                        count--;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine("Brakets are properly placed.");
                }
                else
                {
                    Console.WriteLine("Brakets are inproperly placed.");
                }
            }
                                                                                                      //Zad 5
            static void Counter()
            {
                Console.Write("Place the text:");
                string input = Console.ReadLine().ToLower();
                Console.WriteLine();
                Console.Write("What are we looking for : ");
                string pattern = Console.ReadLine(); ;
                Console.WriteLine();

                int counter = 0;
                int index = input.IndexOf(pattern);
                while (index != -1)
                {
                    counter++;
                    index = input.IndexOf(pattern, index + 1);
                }
                Console.WriteLine($"Count : {counter}");
            }
             
                                                                                                        //Zad 6
            static void Capitals()
            {
                Console.Write("Put your text:");
                string input4 = Console.ReadLine();
                Console.WriteLine();
                string capital;

                int start = input4.IndexOf("<upcase>");
                int end = input4.IndexOf("</upcase>");

                while (start != -1 && end != -1)
                {
                    capital = input4.Substring(start + 8, end - start - 8);
                    input4 = input4.Remove(start, end + 9 - start);
                    input4 = input4.Insert(start, capital.ToUpper());

                    start = input4.IndexOf("<upcase>", end - 8);
                    end = input4.IndexOf("</upcase>", end - 9 - 8);
                }
                Console.WriteLine($"Processd text:{input4}");
            }

                                                                                                      // Zad 7
            static void Starts()
            {
                Console.Write("Write up to 20 symbols :");
                string input5 = Console.ReadLine();
                Console.WriteLine();

                int count = 0;
                foreach (var chars in input5)
                {
                    count++;
                }
                if (count != 20)
                {
                    Console.WriteLine($"Not enough!There will be added {20 - count} stars.");
                    Console.WriteLine();
                    Console.Write(input5);
                    Console.Write(new string('*', 20 - count));
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("It has 20 symbols");
                }
            }                                                                                           //Zad 10
            static void WholeSentence()
            {
                Console.Write("Enter a text:");
                List<string> text = Console.ReadLine()
                    .Split(". ")
                    .ToList();
                Console.WriteLine();
                Console.Write("Enter a word:");
                string word = Console.ReadLine();
                Console.WriteLine();

                List<string> newText = text.Where(x => Regex.IsMatch(x, $"(\\b){word}(\\b)")).ToList();
                Console.WriteLine(newText);
                


            }
                                                                                                       //Zad 11
            static void BadWord()
            {
                Console.Write("Place the text:");
                string input = Console.ReadLine();
                Console.WriteLine();
                Console.Write("What is the benned word?-->");
                string banned = Console.ReadLine();
                Console.WriteLine();

                if (input.Contains(banned))
                {
                    input = input.Replace(banned, new string('*', banned.Length));
                }
                Console.WriteLine($"Censored text:{input}");


            }
                                                                                                   // Zad 12
               static void FifteenIntervals()
            {
                Console.Write("Enter a number:");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine();
                
                string original = number.ToString();
                Console.WriteLine((new string(' ', 15 - original.Length) + original)); 

                string sixteen = number.ToString("X");
                Console.WriteLine((new string(' ', 15 - sixteen.Length) + sixteen));

                string percent = number + "%";
                Console.WriteLine((new string(' ', 15 - percent.Length) + percent));

                string dollars = number.ToString("c");
                Console.WriteLine((new string(' ', 15 - dollars.Length) + dollars));

                string scienti = (number / 2).ToString("f2") + "*2";
                Console.WriteLine((new string(' ', 15 - scienti.Length) + scienti));


            }
                                                                                                      //Zad 13
            static void HTTP()
            {
                Console.Write("State you link:");
                string web = Console.ReadLine();
                Console.WriteLine();

                string pettern = @"(https?)://([a-z.-_0-9]+\.[a-z]{2,3})(/[/.a-z0-9]*)";

                Regex regex = new Regex(pettern, RegexOptions.Compiled | RegexOptions.IgnoreCase);

                var novo = regex.Match(web);


                Console.WriteLine($"[protocol] =\"{ novo.Groups[1].Value}\"");
                Console.WriteLine($"[server]=\"{ novo.Groups[2].Value}\"");
                Console.WriteLine($"[resources]=\"{ novo.Groups[3].Value}\"");
            }
                                                                                                        //Zad 14
            static void YodaSense()
            {
                Console.Write("Place your text here:");
                string[] input10 = Console.ReadLine().Split(" ");
                Console.WriteLine();

                StringBuilder newString = new StringBuilder();

                for (int i = input10.Length; i > 0; i--)
                {
                    newString.Append(input10[i - 1]+ ' ');
                }
                Console.WriteLine($"Reversed:{newString}");


            }
                                                                                                        //Zad 15
            static void DattaForDummies()
            {
               
                Dictionary<string, string> safe = new Dictionary<string, string>();

                Console.WriteLine("That's the dictionary! Make sure to place '-' between word and his meaning. ");
                Console.WriteLine();
                Console.WriteLine("How many words do you want to add?");
                int count = int.Parse(Console.ReadLine());

                for (int i = 0; i < count; i++)
                {
                    string[] title = Console.ReadLine()
                        .Split("-");
                    string word = title[0];
                    string explanation = title[1];
                    if (!safe.ContainsKey(word))
                    {
                        safe.Add(word, explanation);
                    }
                }
                Console.Write("State the word that you want to see explained again:");
                Console.WriteLine();
                foreach (var money in safe)
                {
                    string wordTwo = Console.ReadLine();
                    if (money.Key.Contains(wordTwo))
                    {
                        Console.WriteLine(money.Value);
                    }
                }
            }  
                                                                                                 //Zad 16
            static void HTMLedit()
            {
                Console.Write("Enter the text:");
                string text = Console.ReadLine();
                Console.WriteLine();

                text = Regex.Replace(text,"<a href=\"" , "[URL=");
                text = Regex.Replace(text, "</a>", "[/URL]");
                text = Regex.Replace(text, ">", "]");
                text = Regex.Replace(text, "<p]", "<p>");
                text = Regex.Replace(text, "</p]", "</p>");


                Console.Write($"Edited text:{text}");
            }
                                                                                                //Zad 17
            static void MathDate()
            {
                Console.Write("Enter first date:");
                int[] firstDate = Console.ReadLine()
                    .Split('.')
                    .Select(int.Parse)
                    .ToArray();
                Console.WriteLine();

                Console.Write("Enter second date:");
                int[] secondDate = Console.ReadLine()
                    .Split('.')
                    .Select(int.Parse)
                    .ToArray();
                Console.WriteLine();

                DateTime date1 = new DateTime(firstDate[2],firstDate[1],firstDate[0]);
                DateTime date2 = new DateTime(secondDate[2],secondDate[1],secondDate[0]);

                TimeSpan n = date1 - date2;
                int totalDays = n.Days;

                Console.WriteLine($"Total days:{totalDays}");
            }
                                                                                                    //Zad 18
            static void MathDateSecondForm ()
            {
                Console.Write("Enter a date and hours:");                                         // За проверка на кода 15.06.2008 08:30:00
                string text = Console.ReadLine();
              
                DateTime date = DateTime.ParseExact(text, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                

                date = date.AddHours(6);
                date = date.AddMinutes(30);

                Console.WriteLine($"After 6 hours and 30 minutes it is:{date.ToString("dd.MM.yyyy HH:mm:ss")}");
            }
                                                                                                         //Zad 19
            static void Email ()
            {
                Console.Write("Put the text here:");
                string text = Console.ReadLine();
                Console.WriteLine();

                string patternn = @"[^\s@]+@([^\s@.,]+\.)+[^\s@.,]{2,}";

                Regex regex = new Regex(patternn, RegexOptions.Compiled | RegexOptions.IgnoreCase);
                MatchCollection matches = regex.Matches(text);
                Console.WriteLine("Founded emails:");
                foreach (Match item in matches)
                {
                    Console.WriteLine(item);
                }
            }
                                                                                                             //Zad 20
            static void DateTaker()
            {
                Console.Write("Put your text here:");
                string text = Console.ReadLine();
                Console.WriteLine();

                string patern = @"(([0-2]?\d)|(3[0-1]))\.((0?\d)|(1[0-2]))\.((1\d\d\d)|(20[0-1]\d)|(202[0-1]))";
                Regex regex = new Regex(patern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
                MatchCollection matches = regex.Matches(text);
                foreach (Match item in matches)
                {
                    Console.WriteLine(item);
                }
            }
                                                                                                              //Zad 21
            static void Palindromi()
            {
                Console.WriteLine();
                Console.Write("Put your text here:");
                string text = Console.ReadLine();
                Console.WriteLine();
                string pattern = @"(\w)(?:(\w)(?:(\w)\3?)?\2?)?\1";

                Regex regex = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);

                MatchCollection matches = regex.Matches(text);
                foreach (Match item in matches)
                {
                    Console.WriteLine(item);
                }
            }
            static void HowMuchChars() 
            {                                                                       // 22 zad
                string input = Console.ReadLine();

                Dictionary<char, int> countingChars = new Dictionary<char, int>();

                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] != ' ')
                    {
                        if (countingChars.ContainsKey(input[i]) == false)
                        {
                            countingChars.Add(input[i], 0);
                        }
                        countingChars[input[i]]++;
                    }
                }
                foreach (var smt in countingChars)
                {
                    Console.WriteLine($"{smt.Key} -> {smt.Value}");
                }
            }
        
             static void HowMuchWords ()                                                     // zad 23
             {
                string[] input = Console.ReadLine().Split();

                SortedDictionary<string, int> symbols = new SortedDictionary<string, int>();

                foreach (var word in input)
                {
                    if (symbols.ContainsKey(word))
                    {
                        symbols[word]++;
                    }
                    else
                    {
                        symbols[word] = 1;
                    }
                }

                foreach (var symbol in symbols)
                {
                    Console.WriteLine("{0} -> {1}", symbol.Key, symbol.Value);
                }
             }
        

            static void SameLetters ()
            {                                                                       //24 zad
                string input = Console.ReadLine();

                for (int i = 1; i < input.Length; i++)
                {
                    if (input[i] == input[i - 1])
                    {
                        input = input.Remove(i - 1, 1);
                        i--;
                    }
                }
            }
            static void AlphabeticalOrder()
            {                                                                      //25 zad
                Console.Write("Place the words here:");
                string[] words = Console.ReadLine()
                    .Split(',')
                    .ToArray();
                   
                Console.WriteLine();

                Array.Sort(words);
                Console.Write("Sorted words:");
                foreach (var item in words)
                {
                    Console.Write(item + ",");
                }
            }

        }
    }
}

  


