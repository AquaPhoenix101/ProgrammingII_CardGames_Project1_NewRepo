using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProgrammingII_CardGames_Project1.Utility;
using static System.Console;

namespace ProgrammingII_CardGames_Project1
{
    public class Player
    {
        private string name = "Player";

        public Player() {  }

        public Player(string _name)
        {
            name = _name;
        }

        public string Name
        {
            get => name;
            set
            {

                name = value;
            }
        }

        public void ChangeName()
        {
            Print("What is your name, Player?");
            Name = getInputFromPlayer();
            Print("Name update!");
            Pause();
            Clear();
        }

        public List<Card> playerHand = new List<Card>();
        

    }
}
