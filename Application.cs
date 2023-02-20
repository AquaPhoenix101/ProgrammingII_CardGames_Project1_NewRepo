using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProgrammingII_CardGames_Project1.Utility;

namespace ProgrammingII_CardGames_Project1
{
    public class Application
    {
        Game game = new Game();

        public void Menu()
        {
            
            Print($"Welcome {game.player.Name}! What game do you want to play? \n 1) Bugs or Mushrooms \n 2) High Card Low Card \n 3) Highest Match \n 4) Credits");
            switch(getInputFromPlayer())
            {
                case "1":
                    game = new BugsOrMushrooms();
                    game.gameName = "Bugs or Mushrooms";
                    game.Start();
                    break;

                case "2":
                    game = new HigherOrLower();
                    game.gameName = "High Card Low Card";
                    game.Start();
                    break;

                case "3":
                    game = new HighestMatch();
                    game.gameName = "Highest Match";
                    game.Start();
                    break;

                case "4":
                    ShowCredits();
                    Menu();
                    return;
                    

            }
        }

        private void ShowCredits()
        {

            Print($"This code was created with the help of Programming 201 pages, Kayla Ricker, and Janell Baxter.\n" +
                $"Press any key to return to the name declaration, thank you for reading!");
            Console.ReadLine();
        }
    }

}
