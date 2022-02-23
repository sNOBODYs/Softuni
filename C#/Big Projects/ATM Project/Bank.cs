using System;
using System.Collections;
using System.Collections.Generic;

namespace Demo1
{
    class Bank
        :IEnumerable<Card>
    {
        public List<Card> Cards = new List<Card>();
        public string Title { get; set; }

        public Bank(string title) 
        {
            this.Title = title;
        }
        
        public string Transfer(Card firstBankAcc, Card secondBankAcc, int value)
        {
            if (value < 0)
            {
                return "The value should not be less than 0!";
            }

            try
            {
                firstBankAcc.Money -= value;
                secondBankAcc.Money += value;
            
                return "Successful Transfer!";
            }
            catch (Exception e)
            {
                return "You don't have enough money to transfer!";
            }
        }

        public Card GetCardByCN(string cardNumber)
        {
            return this.Cards.Find(x => x.CardNumber == cardNumber);
        }

        public Card GetCardByPin(string pin)
        {
            return this.Cards.Find(x => x.Pin == pin);
        }
        
        public void AddCard(Card card )
        {
            Cards.Add(card);
        }
        public void RemoveCard(Card card) 
        {
            Cards.Remove(card);
        }
        public IEnumerator<Card> GetEnumerator()
        {
            foreach (Card card in Cards)
            {
                yield return card;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}