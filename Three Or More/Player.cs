using System;
using static Three_Or_More.Bot;
using static Three_Or_More.Die;

namespace Three_Or_More
{
    class Player
    {
        public static void TakeTurn(int playerscore, int botscore)
        {
            Console.WriteLine("\nPlayer 1, please make your turn. Type 'Roll' or '1' to roll.");  //Program promts user to roll
            bool continuepar = false;   //Bool used for continuing the program after a choice is made.
            do
            {
                string chooseRoll = Console.ReadLine();
                switch (chooseRoll)
                {
                    case "1": case "roll": case "Roll": case "RolL": case "RoLl": case "ROll": case "ROLl": case "ROlL": case "RoLL": case "ROLL": case "yes": case "Yes": case "yEs": case "YEs": case "YeS": case "y": case "Y": Dice(playerscore, botscore); break; //All options for continuing
                    case "0": case "no": case "No": case "n": case "N": case "quit": case "Quit": case "qUit": case "quIt": case "quiT": case "QUit": case "QuIt": case "QuiT": case "qUIt": case "qUiT": case "quIT": case "QUIt": case "QUiT": case "QuIT": case "qUIT": Console.WriteLine("Thanks for playing! Please press any putton to quit"); Dice(playerscore, botscore); break; //All options for quiting  Console.ReadKey(); Environment.Exit(0);
                    default:
                        Console.WriteLine("Valid responses for yes: '1', 'Roll', 'Yes' or 'Y'\nValid responses for no: '0', 'No', 'N' or 'Quit'"); //If the input is invalid, print this line
                        break;  //Stops when the program is finished
                }
            }
            while (continuepar == false);   //Tells the program to repeat the question
        }

        public static void Comparison(int dice1, int dice2, int dice3, int dice4, int dice5, int playerscore, int botscore)
        {
            //If all 5 dice are the same
            if (dice1 == dice2 && dice2 == dice3 && dice3 == dice4 && dice4 == dice5)
            { Console.WriteLine("All dice are the same."); playerscore = playerscore + 12; Console.WriteLine("Your score is: " + playerscore); BotPlay(playerscore, botscore); }
            //If 4 dice are the same
            else if (dice1 == dice2 && dice2 == dice3 && dice3 == dice4 || dice1 == dice2 && dice2 == dice3 && dice3 == dice5 || dice1 == dice2 && dice2 == dice4 && dice4 == dice5 || dice1 == dice3 && dice3 == dice4 && dice4 == dice5 || dice2 == dice3 && dice3 == dice4 && dice4 == dice5)    //If dice 1, 2, 3 and 4 are the same
            { Console.WriteLine("4 dice are the same."); playerscore = playerscore + 6; Console.WriteLine("Your score is: " + playerscore); BotPlay(playerscore, botscore); }
            //If 3 dice are the same
            else if (dice1 == dice2 && dice2 == dice3 || dice1 == dice2 && dice2 == dice4 || dice1 == dice2 && dice2 == dice5 || dice1 == dice3 && dice3 == dice4 || dice1 == dice3 && dice3 == dice5 || dice1 == dice4 && dice4 == dice5 || dice2 == dice3 && dice3 == dice4 || dice2 == dice3 && dice3 == dice5 || dice2 == dice4 && dice4 == dice5 || dice3 == dice4 && dice4 == dice5)  //If dice 1, 2 and 3 are the same
            { Console.WriteLine("3 dice are the same."); playerscore = playerscore + 3; Console.WriteLine("Your score is: " + playerscore); BotPlay(playerscore, botscore); }
            //If two dice are the same
            else if (dice1 == dice2 || dice1 == dice3 || dice1 == dice4 || dice1 == dice5 || dice2 == dice3 || dice2 == dice4 || dice2 == dice5 || dice3 == dice4 || dice3 == dice5 || dice4 == dice5) { Console.WriteLine("2 dice are the same. Reroll!"); Reroll(playerscore, botscore); }
            //Else, if no dice are the same
            else { Console.WriteLine("No two die are the same. What a shame! Next, the bot's turn!"); BotPlay(playerscore, botscore); }
        }
    }
}
