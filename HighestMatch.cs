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
            Instructions = "In this game, you'll face a dealer. Your goal is to get a higher matching pair of cards than them.\n";
            base.Start();
            deck = new Deck();
            deck.MakeDeck(52, new string[] { "Bugs", "Rocks", "Mushrooms", "Leaves" });

            //round setup
            for (int r = 1; r < 11; r++)
            {
                Print($"This is round {r} of 10");
                Play();
            }
        }

        public void Play()
        {

        }

        public void dealerHand()
        { 
        
        }

        public void playerHand()
        {

        }

       

    }
}
