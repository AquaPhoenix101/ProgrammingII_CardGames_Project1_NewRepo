using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProgrammingII_CardGames_Project1.Utility;

namespace ProgrammingII_CardGames_Project1
{
    class HighestMatch: Game
    {

        public override void Start()
        {
            gameName = "Highest Match";
            Instructions = "In this game, you'll face a dealer. Your goal is to match suits to add up to a higher score than the dealer.\n";
            base.Start();
            deck = new Deck();
            deck.MakeDeck(52, new string[] { "Bugs", "Rocks", "Mushrooms", "Leaves" });
            Play();

            //round setup
          
        }
        string[] Shuffle(string[] unshuffled)
        {
            Random random = new Random();
            List<string> shuffled = unshuffled.ToList().OrderBy(a => random.Next()).ToList();
            return shuffled.ToArray();
        }
        public void Play()
        {
            //temp setup
            string[] suits = { "Bugs", "Rocks", "Mushrooms", "Leaves" };
            Random randomNumber = new Random();
            int randomElement = randomNumber.Next(suits.Length);
            string temp = suits[randomElement];
            suits[randomElement] = suits[0];
            suits[0] = temp;
            int number = randomNumber.Next(1, 13);
            //string[] shufflesuits = Shuffle(suits);
            int num1 = number;
            string temp1 = temp;
            bool match;
            string tempp = suits[randomElement];
            suits[randomElement] = suits[0];
            suits[0] = tempp;
            int number1 = randomNumber.Next(1, 13);

            int num2 = number1;
            string temp2 = tempp;

            deck.Shuffle();
            dealHand();

            for (int r = 1; r < 11; r++)
            {
                Print($"This is round {r} of 10\n");
                foreach(Card c in player.playerHand)
                {
                    Print(c.ShowDescription());
                }
                Console.ReadKey();
            }

            

        }


        public void dealHand()
        {
            for (int i = 0; i < 4; i++)            
                
            {
                player.playerHand.Add(deck.DrawCard());
                dealer.playerHand.Add(deck.DrawCard());
            }
        }

       

    }
}
