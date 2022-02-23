using System;
using System.Linq;
using System.Threading;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank("ATM");
            HomePage(bank);
        }
        public static void HomePage(Bank bank)
        {
            Console.Clear();

            Console.WriteLine("                                   ╔═══╦════╦═╗╔═╗");
            Console.WriteLine("                                   ║╔═╗║╔╗╔╗║║╚╝║║");
            Console.WriteLine("                                   ║║─║╠╝║║╚╣╔╗╔╗║");
            Console.WriteLine("                                   ║╚═╝║─║║─║║║║║║");
            Console.WriteLine("                                   ║╔═╗║─║║─║║║║║║");
            Console.WriteLine("                                   ╚╝─╚╝─╚╝─╚╝╚╝╚╝");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("> Register a Card <");
            Console.WriteLine("> Log in <");
            Console.WriteLine();
            Console.Write("Input: ");
            
            string input = Console.ReadLine().ToLower();
            if (input == "register")
            {
                Register(bank);
            }
            else if (input == "log in")
            {
                CardGuessMethod(bank);
            }
            else if (input == "admin")
            {
                foreach (Card card in bank.OrderBy(x => x))
                {
                    Console.WriteLine(card);
                }
                
                Thread.Sleep(2000);
                HomePage(bank);
            }
        }
        public static void CardGuessMethod(Bank bank)
        {
            Console.Clear();
            
            Console.WriteLine("Please enter your card number:");
            string userInput = Console.ReadLine().Trim();
            Card card = bank.GetCardByCN(userInput);
            
            if (card != null)
            {
                PinGuessMethod(bank);
            }
            else
            {
                Console.WriteLine("Card invalid!");
                
                Thread.Sleep(2000);
                HomePage(bank);
            }
        }
        
        public static void PinGuessMethod(Bank bank)
        {
            Console.Write("Enter your Pin Number: ");
            string userInput = Console.ReadLine();
            Card card = bank.GetCardByPin(userInput);
            
            if (card != null)
            {
                MethodsBank(bank, card);
            }
            else
            {
                Console.WriteLine("Error 404: Wrong Pin");
                
                Thread.Sleep(2000);
                HomePage(bank);
            }
        }
        
        public static void MethodsBank(Bank bank, Card card)
        {
            while (true)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Log out     Withdraw      Deposit      Transfer");
                Console.Write("Please write here: ");
            
                string function = Console.ReadLine().Trim().ToLower();
                if (function == "log out")
                {
                    break;
                }
                
                if (function == "withdraw")
                {
                    Console.WriteLine("Please enter the wanted amount to be withdrawn:");
                    int amount = int.Parse(Console.ReadLine());
                
                    Console.WriteLine(card.Withdraw(amount));
                }
                else if (function == "deposit")
                {
                    Console.WriteLine("Please enter a deposit amount:");
                    int amount = int.Parse(Console.ReadLine());

                    Console.WriteLine(card.Deposit(amount));
                }
                else if (function == "transfer")
                {
                    Console.WriteLine("Please enter the card number of another card:");
                    string anotherCardNumber = Console.ReadLine();
                    Card anotherCard = bank.GetCardByCN(anotherCardNumber);
                
                    if (anotherCard == null)
                    {
                        Console.WriteLine("Invalid card number!");
                        return;
                    }
                    
                    Console.WriteLine("Please enter the wanted amount to be transferred:");
                    int wantedAmount = int.Parse(Console.ReadLine());

                    Console.WriteLine(bank.Transfer(card, anotherCard, wantedAmount));
                }
                
                Thread.Sleep(2000);
                Console.WriteLine();
            }
            
            Console.WriteLine("Thanks for Banking with us.");
            
            Thread.Sleep(2000);
            HomePage(bank);
        }
        
        public static void Register(Bank bank) 
        {
            Console.Clear();

            Console.WriteLine("Please enter first name, second name, card number, pin and money, separated by comma.");
            Console.WriteLine();
            Console.WriteLine("Input: ");

            string[] info = Console.ReadLine().Split(',');
            string firstName = info[0];
            string secondName = info[1];
            string cardNum = info[2];
            string pin = info[3];

            Card card = new Card(firstName, secondName, cardNum, pin);
            bank.AddCard(card);
            
            Console.WriteLine($"Successfully registered! {firstName} {secondName}");
            Thread.Sleep(2000);
            HomePage(bank);
        }
    }

}