using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProgrammingII_CardGames_Project1.Utility;
using static ProgrammingII_CardGames_Project1.Application;

namespace ProgrammingII_CardGames_Project1
{
    public class Game
    {
        public string gameName;
        public int totalScore = 0;
        public int dealerScore = 0;
        public int currentScore = 0;
        public bool gameEnd = false;
        public string Instructions;
        public Deck deck;
        public Player player = new Player();
        public Player dealer = new Player();        


        public virtual void Start()
        {
            Print($"Welcome to {gameName}!");
            Print($"{Instructions}");
            player.ChangeName();
        }

    }
}
