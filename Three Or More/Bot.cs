using System;
using static Three_Or_More.Player;
using static Three_Or_More.Three_Or_More.Game;

namespace Three_Or_More
{
    class Bot
    {
        public static void BotPlay(int playerscore, int botscore)
        {
            //Sets bot's colour scheme to display when it is their turn
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("\nThe bot is now playing their turn.");
            Random rnd = new Random();  //Creates new random
            int bpdice1 = rnd.Next(1, 7);  //Chooses the bot's dice 1 value
            int bpdice2 = rnd.Next(1, 7);  //Chooses the bot's dice 1 value
            int bpdice3 = rnd.Next(1, 7);  //Chooses the bot's dice 1 value
            int bpdice4 = rnd.Next(1, 7);  //Chooses the bot's dice 1 value
            int bpdice5 = rnd.Next(1, 7);  //Chooses the bot's dice 1 value
            

            //If all 5 dice are the same
            if (bpdice1 == bpdice2 && bpdice2 == bpdice3 && bpdice3 == bpdice4 && bpdice4 == bpdice5)
            { Console.WriteLine("The bot's dice all dice are the same."); botscore = botscore + 12; Console.WriteLine("Bot's score is: " + botscore); }

            //If The bot rolled the same 4 dice
            else if (bpdice1 == bpdice2 && bpdice2 == bpdice3 && bpdice3 == bpdice4 || bpdice1 == bpdice2 && bpdice2 == bpdice3 && bpdice3 == bpdice5 || bpdice1 == bpdice2 && bpdice2 == bpdice4 && bpdice4 == bpdice5 || bpdice1 == bpdice3 && bpdice3 == bpdice4 && bpdice4 == bpdice5 || bpdice2 == bpdice3 && bpdice3 == bpdice4 && bpdice4 == bpdice5)
            { Console.WriteLine("The bot rolled the same 4 dice."); botscore = botscore + 6; Console.WriteLine("Bot's score is: " + botscore); }

            //If the bot rolled the same 3 dice
            else if (bpdice1 == bpdice2 && bpdice2 == bpdice3 || bpdice1 == bpdice2 && bpdice2 == bpdice4 || bpdice1 == bpdice2 && bpdice2 == bpdice5 || bpdice1 == bpdice3 && bpdice3 == bpdice4 || bpdice1 == bpdice3 && bpdice3 == bpdice5 || bpdice1 == bpdice4 && bpdice4 == bpdice5 || bpdice2 == bpdice3 && bpdice3 == bpdice4 || bpdice2 == bpdice3 && bpdice3 == bpdice5 || bpdice2 == bpdice4 && bpdice4 == bpdice5 || bpdice3 == bpdice4 && bpdice4 == bpdice5)
            { Console.WriteLine("The bot rolled the same 3 dice."); botscore = botscore + 3; Console.WriteLine("Bot's score is: " + botscore); }

            //If the bot rolled the same 2 dice
            else if (bpdice1 == bpdice2 || bpdice1 == bpdice3 || bpdice1 == bpdice4 || bpdice1 == bpdice5 || bpdice2 == bpdice3 || bpdice2 == bpdice4 || bpdice2 == bpdice5 || bpdice3 == bpdice4 || bpdice3 == bpdice5 || bpdice4 == bpdice5) { Console.WriteLine("The bot rolled the same two dice. The bot gets to re-roll!"); BotReroll(playerscore, botscore); }
            
            //Else, if no dice are the same
            else { Console.WriteLine("No two die are the same. What a shame! Next, the player's turn!"); }
            
            Console.ResetColor(); //Removes bot's colour scheme
            Score(playerscore, botscore); //Goes to check the scores
        }

        public static void BotReroll(int playerscore, int botscore)
        {
            //This method is for when the but gets to re-roll because two of the previous dice were the same value
            Random rnd = new Random();  //Creates new random
            int bpdice1 = rnd.Next(1, 7); //Chooses dice 1's value
            int bpdice2 = rnd.Next(1, 7); //Chooses dice 2's value
            int bpdice3 = rnd.Next(1, 7); //Chooses dice 3's value

            //Displays dice rolls ↓
            //Console.WriteLine("You rolled a " + bpdice1 + ".\nYou rolled a " + bpdice2 + ".\nYou rolled a " + bpdice3 + ".\n");

            //If all other 3 dice are the same
            if (bpdice1 == bpdice2 && bpdice2 == bpdice3)
            { Console.WriteLine("All 3 other dice are the same."); botscore = botscore + 12; Console.WriteLine("The bot's score is: " + botscore); }

            //If 2 other dice are the same
            else if (bpdice1 == bpdice2 || bpdice1 == bpdice3 || bpdice2 == bpdice3)    //If dice 1 and 2 are the same
            { Console.WriteLine("2 other dice are the same."); botscore = botscore + 6; Console.WriteLine("The bot's score is: " + botscore); }

            //Else, if no other dice are the same
            else { Console.WriteLine("Unfortunatly no other dice are the same. What a shame! Next, the player's turn!"); }
            Console.ResetColor();
            Score(playerscore, botscore); //Goes to check the scores
        }
    }
}
