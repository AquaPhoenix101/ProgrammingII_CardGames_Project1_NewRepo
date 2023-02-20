using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingII_CardGames_Project1
{
    public class Card
    {
        private string Suit;
        private int Value;
        private int cardAmount;

        public Card(string suit, int value)
        {
            Suit = suit;
            Value = value;
        }

        public string ShowDescription() => ($"The card is the {Value} of {Suit}");
    }
}
