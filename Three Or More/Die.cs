using System;
using static Three_Or_More.Player;
using static Three_Or_More.Bot;

namespace Three_Or_More
{
    class Die
    {
        public static void Dice(int playerscore, int botscore)
        {
            Console.WriteLine("\nDice rolls: \n");  //Tells user they rolled the dice
            Random rnd = new Random();  //Creates new random
            int dice1 = rnd.Next(1, 7); //Chooses dice 1's value
            int dice2 = rnd.Next(1, 7); //Chooses dice 2's value
            int dice3 = rnd.Next(1, 7); //Chooses dice 3's value
            int dice4 = rnd.Next(1, 7); //Chooses dice 4's value
            int dice5 = rnd.Next(1, 7); //Chooses dice 5's value

            //Displays dice rolls ↓
            Console.WriteLine("You rolled a " + dice1 + ".\nYou rolled a " + dice2 + ".\nYou rolled a " + dice3 + ".\nYou rolled a " + dice4 + ".\nYou rolled a " + dice5 + ".\n");
            Comparison(dice1, dice2, dice3, dice4, dice5, playerscore, botscore); //Goes to Comparison() method
        }

        public static void Reroll(int playerscore, int botscore)
        {
            //This method is for when the User gets to re-roll because two of the previous dice were the same value
            Console.WriteLine("\nDice rolls: \n");  //Tells user they rolled the dice
            Random rnd = new Random();  //Creates new random
            int dice1 = rnd.Next(1, 7); //Chooses dice 1's value
            int dice2 = rnd.Next(1, 7); //Chooses dice 2's value
            int dice3 = rnd.Next(1, 7); //Chooses dice 3's value

            //Displays dice rolls ↓
            Console.WriteLine("You rolled a " + dice1 + ".\nYou rolled a " + dice2 + ".\nYou rolled a " + dice3 + ".\n");

            //If all other 3 dice are the same
            if (dice1 == dice2 && dice2 == dice3)
            { Console.WriteLine("All 3 other dice are the same."); playerscore = playerscore + 12; Console.WriteLine("Your score is: " + playerscore); }

            //If 2 other dice are the same
            else if (dice1 == dice2 || dice1 == dice3 || dice2 == dice3)    //If dice 1 and 2 are the same
            { Console.WriteLine("2 other dice are the same."); playerscore = playerscore + 6; Console.WriteLine("Your score is: " + playerscore); }

            //Else, if no other dice are the same
            else { Console.WriteLine("Unfortunatly no other dice are the same. What a shame! Next, the bot's turn!"); }
            BotPlay(playerscore, botscore); //Goes to the bot
        }
    }
}
