using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProgrammingII_CardGames_Project1.Utility;
using static ProgrammingII_CardGames_Project1.Application;

namespace ProgrammingII_CardGames_Project1
{
    public class BugsOrMushrooms: Game
    {

        public override void Start()
        {
            gameName = "Bugs Or Mushrooms";
            Instructions = "I'll show you a card that has either the Bug suit or Mushroom suit.\nYou must guess if the next card in the deck is the same or different suit from the previous card.";
            base.Start();
            deck = new Deck();
            deck.MakeDeck(26, new string[] { "Bugs", "Mushrooms" });

            for (int r = 1; r < 11; r++)
            {
                Print($"This is round {r} of 10");
                Play();
            }
        }


        public void Play()
        {
            //code created with help of Prog 201 examples and Kayla Ricker
            string[] suits = { "Bugs", "Mushrooms" };
            string[] suits2 = { "bugs", "mushrooms" };
            Random randomNumber = new Random();
            int randomElement = randomNumber.Next(suits.Length);
            string temp = suits[randomElement];
            suits[randomElement] = suits[0];
            suits[0] = temp;
            int number = randomNumber.Next(1, 13);
            string[] shufflesuits = Shuffle(suits); //watch here for breaks
            int num1 = number;
            string temp1 = temp;
            bool match;

            string tempp = suits[randomElement];
            suits[randomElement] = suits[0];
            suits[0] = tempp;
            int number1 = randomNumber.Next(1, 13);

            int num2 = number1;
            string temp2 = tempp;

            Print($"{num1} of {temp1}");

            if(temp1 == temp2)
            {
                match = true;
            }
            else
            {
                match = false;
            }

            //made with help from Kayla Ricker
            string[] Shuffle(string[] unshuffled)
            {
                Random random = new Random();
                List<string> shuffled = unshuffled.ToList().OrderBy(a => random.Next()).ToList();
                return shuffled.ToArray();
            }

            Print("Do you think the next suit will be the same? \n 1)Yes \n 2)No ");
            switch (getInputFromPlayer())
            {

                case "1":
                    if (match == true)
                    {
                        Print("Correct! You've gussed correctly, one point for you!");
                        currentScore++;
                        Print($"You have {currentScore} points\n");
                        Pause();
                    }
                    else
                    {
                        Print("Looks like you were wrong...");
                        Print($"You have {currentScore} points\n");
                        Pause();
                    }
                    break;

                case "2":
                    if (match == false)
                    {
                        Print("Correct! You've gussed correctly, one point for you!");
                        currentScore++;
                        Print($"You have {currentScore} points\n");
                        Pause();
                    }
                    else
                    {
                        Print("Looks like you were wrong...");
                        Print($"You have {currentScore} points\n");
                        Pause();
                    }
                    break;


            }
            Console.Clear();

        }
    }
}
