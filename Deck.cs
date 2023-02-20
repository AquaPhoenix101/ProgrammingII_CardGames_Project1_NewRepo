using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProgrammingII_CardGames_Project1.Utility;

namespace ProgrammingII_CardGames_Project1
{
    public class Deck
    {
        public int deckSize;
        public int suitNumber;
        public List<Card> Cards = new List<Card>();

        public void MakeDeck(int cardAmount, string[] suit)
        {
            for (int i = 0; i < suit.Length; i++)
            {
                for(int j = 1; j < (cardAmount / suit.Length) +1; j++)
                {
                    Cards.Add(new Card(suit[i], j));
                }
            }
        }

        public void ShowDeck()
        {
            foreach(Card c in Cards)
            {
                Print($"{c.ShowDescription()}");
            }
        }

        public void GetDeck()
        {
            deckSize = 52;
            string[] suits = { "Rocks", "Leaves", "Bugs", "Mushrooms" };
            suitNumber = 4;

            for (int i = 1; i <= deckSize / suitNumber; i++)
            {
                Print($"{i} of {suits[0]}");
            }

            for (int i = 1; i <= deckSize / suitNumber; i++)
            {
                Print($"{i} of {suits[1]}");
            }
            for (int i = 1; i <= deckSize / suitNumber; i++)
            {
                Print($"{i} of {suits[2]}");
            }

            for (int i = 1; i <= deckSize / suitNumber; i++)
            {
                Print($"{i} of {suits[3]}");
            }

            Shuffle();
        }

        public void Shuffle()
        {
            string[] suits = { "Rocks", "Leaves", "Bugs", "Mushrooms" };
            Random randomNumber = new Random();
            int randomElement = randomNumber.Next(suits.Length);
            string temp = suits[randomElement];
            suits[randomElement] = suits[0];
            suits[0] = temp;
            int number = randomNumber.Next(1, 13);

            string[] shuffleSuits = Shuffle(suits);

            string[] Shuffle(string[] unshuffled)
            {
                Random random = new Random();
                List<string> shuffled = unshuffled.ToList().OrderBy(a => random.Next()).ToList();
                return shuffled.ToArray();
            }
        }

    }
}
