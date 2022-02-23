using System;

namespace Demo1
{
     public class Card 
        :IComparable<Card>
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string CardNumber { get; set; }
        public string Pin { get; set;}
        private int money { get; set; }
        public Card (string firstName, string secondName, string cadNumber, string pin)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.CardNumber = cadNumber;
            this.Pin = pin;
            this.Money = 0;
        }

        public int Money
        {
            get => money;
            set
            {
                if (value < 0)
                {
                    throw new Exception("The money cannot be set to less than $0!");
                }

                money = value;
            }
        }

        public bool IsValid(int value)
        {
            if (value < 0 || value > 1000)
            {
                return false;
            }

            return true;
        }

        public string Deposit(int value)
        {
            if (!IsValid(value))
            {
                return "The value should not be less than $0 or more than $1000!";
            }   
            
            this.Money += value;
            return $"Successful Deposit! Current amount: ${this.Money}";
        }

        public string Withdraw(int value)
        {
            if (!IsValid(value))
            {
                return "The value should not be less than 0 or more than 1000!";
            }

            try
            {
                this.Money -= value;
                return $"Successful Withdraw! Current amount: ${this.Money}";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.SecondName} {this.CardNumber} {this.Pin} {this.Money} ";
        }

        public int CompareTo(Card other)
        {
            int result = CardNumber.CompareTo(other.CardNumber);
            
            if (result == 0)
            {
                result = FirstName.CompareTo(other.FirstName);
            }
            return result;
        }
    }
}