using System;
using System.Collections.Generic;
using System.Text;

namespace CardCreator
{
    public class Card
    {
        public readonly CardValue cardValue;
        public readonly Type type;

        public Card(CardValue cardValue, Type type)
        {
            this.cardValue = cardValue;
            this.type = type;
        }
    }
}
