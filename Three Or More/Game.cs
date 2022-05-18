using System;
using static Three_Or_More.Player;

namespace Three_Or_More.Three_Or_More
{
    class Game
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Three Or More\n");    //Title
            Console.WriteLine("Rules of Three Or More: \n" +    //Rules
                "\nPlayers take turns rolling five dice and score for three-of-a-kind or better. " +
                "\nIf a player only has two-of-a-kind, they may re-throw the remaining dice\nin an attempt to improve the remaining dice values." +
                "\nIf no matching numbers are rolled after two rolls, the player scores 0." +
                "\n\nIn this game, you will be up against a bot.\nThe bot does not tell you its rolls (mainly for simplicity on the console), but will give you its scoring and tell you if it needs a re-roll.");
            ScoreSet(); //Sets/Resets player's and bot's scores
        }

        public static void ScoreSet()
        {
            //Sets/Resets player's and bot's score as 0
            int playerscore = 0;
            int botscore = 0;
            Score(playerscore, botscore); //Goes to Score() method
        }

        public static void Score(int playerscore, int botscore)
        {
            //If the player's score is 50 or more, the player wins
            if (playerscore >= 50)
            {
                Console.WriteLine("\nAnd the Player wins!\nPlayer's score: " + playerscore + "\nThe bot's score: " + botscore);
                Console.WriteLine("\nWould you like to play again?");  //Program promts user to play again
                bool continuepar = false;   //Bool used for continuing the program after a choice is made.
                do
                {
                    string chooseToContinue = Console.ReadLine();
                    switch (chooseToContinue)
                    {
                        case "1": case "roll": case "Roll": case "RolL": case "RoLl": case "ROll": case "ROLl": case "ROlL": case "RoLL": case "ROLL": case "yes": case "Yes": case "yEs": case "YEs": case "YeS": case "y": case "Y": Main(); break; //All options for continuing
                        case "0": case "no": case "No": case "n": case "N": case "quit": case "Quit": case "qUit": case "quIt": case "quiT": case "QUit": case "QuIt": case "QuiT": case "qUIt": case "qUiT": case "quIT": case "QUIt": case "QUiT": case "QuIT": case "qUIT": Console.WriteLine("Thanks for playing! Please press any putton to quit"); Main(); break; //All options for quiting  Console.ReadKey(); Environment.Exit(0);
                        default:
                            Console.WriteLine("Valid responses for yes: '1', 'Roll', 'Yes' or 'Y'\nValid responses for no: '0', 'No', 'N' or 'Quit'"); //If the input is invalid, print this line
                            break;  //Stops when the program is finished
                    }
                }
                while (continuepar == false);   //Tells the program to repeat the question
            }

            //Else, if the bot's score is 50 or more, the bot wins
            else if (botscore >= 50)
            {
                Console.WriteLine("\nAnd the Bot wins! \nThe bot's score: " + botscore + "\nPlayer's score: " + playerscore);
                Console.WriteLine("\nWould you like to play again?");  //Program promts user to play again
                bool continuepar = false;   //Bool used for continuing the program after a choice is made.
                do
                {
                    string chooseToContinue = Console.ReadLine();
                    switch (chooseToContinue)
                    {
                        case "1": case "roll": case "Roll": case "RolL": case "RoLl": case "ROll": case "ROLl": case "ROlL": case "RoLL": case "ROLL": case "yes": case "Yes": case "yEs": case "YEs": case "YeS": case "y": case "Y": Main(); break; //All options for continuing
                        case "0": case "no": case "No": case "n": case "N": case "quit": case "Quit": case "qUit": case "quIt": case "quiT": case "QUit": case "QuIt": case "QuiT": case "qUIt": case "qUiT": case "quIT": case "QUIt": case "QUiT": case "QuIT": case "qUIT": Console.WriteLine("Thanks for playing! Please press any putton to quit"); Main(); break; //All options for quiting  Console.ReadKey(); Environment.Exit(0);
                        default:
                            Console.WriteLine("Valid responses for yes: '1', 'Roll', 'Yes' or 'Y'\nValid responses for no: '0', 'No', 'N' or 'Quit'"); //If the input is invalid, print this line
                            break;  //Stops when the program is finished
                    }
                }
                while (continuepar == false);   //Tells the program to repeat the question
            }
            else { TakeTurn(playerscore, botscore); } //If no-one has 50 or more points, make the player take their turn again.
        }
    }
}
