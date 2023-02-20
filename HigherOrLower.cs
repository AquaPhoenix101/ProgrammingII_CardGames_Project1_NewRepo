using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProgrammingII_CardGames_Project1.Utility;

namespace ProgrammingII_CardGames_Project1
{
    class HigherOrLower: Game
    {

        public override void Start()
        {
            gameName = "High Card Low Card";
            Instructions = "You'll be shown a random number between 1-13 and you will guess if the next card will be higher or lower than the card just drawn.\n";
            base.Start();
            deck = new Deck();
            deck.MakeDeck(52, new string[] { "Bugs", "Rocks", "Mushrooms", "Leaves" });


            //round setup
            for( int r=1; r <11; r++)
            {
                Print($"This is round {r} of 10");
                Play();
            }
        }

        public void Play()
        {


            //temp setup
            string[] suits = { "Bugs", "Rocks", "Mushrooms", "Leaves"};
            Random randomNumber = new Random();
            int randomElement = randomNumber.Next(suits.Length);
            string temp = suits[randomElement];
            suits[randomElement] = suits[0];
            suits[0] = temp;
            int number = randomNumber.Next(1, 13);
            string[] shufflesuits = Shuffle(suits);
            int num1 = number;
            string temp1 = temp;
            bool match;
            string tempp = suits[randomElement];
            suits[randomElement] = suits[0];
            suits[0] = tempp;
            int number1 = randomNumber.Next(1, 13);

            int num2 = number1;
            string temp2 = tempp;

           //comparison
            Print($"The card drawn is the {num1} of {temp1}");
            if (num1 < num2)
            {
                match = true;
            }
            else
            {
                match = false;
            }

            string[] Shuffle(string[] unshuffled)
            {
                Random random = new Random();
                List<string> shuffled = unshuffled.ToList().OrderBy(a => random.Next()).ToList();
                return shuffled.ToArray();
            }


            //code made with help of Prog 201 pages and Kayla Ricker
            Print("Do you think the next card will be higher or lower? \n 1) Higher \n 2) Lower");
            switch (getInputFromPlayer())
            {
                case "1":
                    if (match == true)
                    {
                        Print("Good Job! You got it right! One point for you!");
                        currentScore++;
                        Print($"You have {currentScore} points\n");
                        Pause();
                    }
                    else
                    {
                        Print("Wrong! You guessed this incorrectly...");
                        Print($"You have {currentScore} points\n");
                        Pause();
                       
                    }
                    break;
                   

                case "2":
                    if (match == false)
                    {
                        Print("Good Job! You got it right! One point for you!");
                        currentScore++;
                        Print($"You have {currentScore} points\n");
                        Pause();
                    }
                    else
                    {
                        Print("Wrong! You guessed this incorrectly...");
                        Print($"You have {currentScore} points\n");
                        Pause();
                       
                    }
                    break;
                    



            }
            Console.Clear();


        }

    }
}
