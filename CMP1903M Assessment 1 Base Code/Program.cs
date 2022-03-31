using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CMP1903M_Assessment_1_Base_Code.Input;
using static CMP1903M_Assessment_1_Base_Code.Analyse;
using static CMP1903M_Assessment_1_Base_Code.Report;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Program
    {
        public static void Main()
        {
            //Bool used for continuing the program after a choice is made.
            bool continuepar = false;

            //Base Code:
            ///Create 'Input' object
            ///Get either manually entered text, or text from a file

            //Promps User to choose between 1 and 2
            Console.WriteLine("Which input would you like to choose?\nType in '1' for text input\nType in '2' for an already located file input");
            Console.WriteLine("Please Choose: ");
            do
            {
                string answerOption = Console.ReadLine(); //Reads input

                switch (answerOption)
                {
                    // A basic UI that allows the use to select between using a file or typing
                    // taking the text input directly
                    case "1": //If the User inputs '1'...
                        continuepar = true; //Tells the program to continue
                        Input.manualTextInput(); //Allows the User to input stuff
                        break; //Stops when the User is finished
                    
                    case "2": //If the User inputs '2'...
                        Console.WriteLine("Reading File: CMP1903M Assessment 1 Test File.txt\n");
                        Console.WriteLine(Input.fileTextInput("CMP1903M Assessment 1 Test File.txt")); //Writes whatever is in the .txt file
                        string input = Input.fileTextInput("CMP1903M Assessment 1 Test File.txt"); //Turns that text into a string

                        //Any word longer than 7 letters gets put on a new "longwords.txt" file
                        string fileContents = File.ReadAllText("CMP1903M Assessment 1 Test File.txt"); //Reads text
                        var result = fileContents.Split(' ', ';', ',', '.', ':') //Splits text into words
                            .Where(x => x.Length >= 8); //Detects length of each word and prints any with 8 or more letters

                        if (File.Exists(@"Long Words.txt")) //Detects if the file already exists
                        {
                            File.Delete(@"Long Words.txt"); //Deletes the file if the file already exists
                        }
                        string path = "Long Words.txt"; //Creates file
                        
                        //Prints list of words longer than 7 letters
                        using (StreamWriter sw = File.AppendText(path))
                        {
                            
                            sw.WriteLine("List of all words 8 letters or more: \n"); //Title or subtitle
                            foreach (var word in result) //Foreach word that contains 8 or more letters
                            {
                                sw.WriteLine(word); //Print that word
                            }
                        }
                        Console.WriteLine("\nCreated a new file: 'Long Words.txt"); //This tells the User the Long Words.txt file has been created

                        Analyse.analyseText(input); //Analyses original .txt file
                        break; //Stops when the program is finished
                    
                    default:
                        Console.WriteLine("Invalid answer. Please enter 1 or 2."); //If the input is invalid, print this line
                        break; //Stops when the program is finished
                }

            } while (continuepar == false); //Tells the program to repeat the question
        }
    }
}