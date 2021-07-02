using System;
using System.Collections.Generic;
using System.Text;

namespace CardCreator
{
    public class Deck
    {
        public List<Card> CardList { get; set; }

        public Deck()
        {
            this.CardList = new List<Card>();
            foreach (Type type in Enum.GetValues(typeof(Type)))
            {
                foreach (CardValue cardValue in Enum.GetValues(typeof(CardValue)))
                {
                    CardList.Add(new Card(cardValue, type));
                }
            }
        }
    }
}
