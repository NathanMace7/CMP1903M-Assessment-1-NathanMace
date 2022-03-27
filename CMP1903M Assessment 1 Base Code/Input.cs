using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public static class Input
    {
        
        //Handles the text input for Assessment 1
        static string text = "";

        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public static string manualTextInput()
        {
            Console.WriteLine("\nYou may now enter your text.\nPlease enter a sentence at a time (Pressing 'Enter' at the end of the sentence).\nPlease use full stop (.) when finishing a sentence!\nTo end your submission please use a singular asterisk (*) on a new line.\n");
            Console.WriteLine("Your text: "); //Prompts User to input text
            string input = Console.ReadLine();  // Takes user input
            text += input;
            while (input != "*")
            {
                input = Console.ReadLine();
                text += input;
            }
            //Input.fileTextInput("CMP1903M Assessment 1 Test File.txt");
            string input2 = input;

            //Analyses text
            Analyse.analyseText(text);
            return text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        
        public static string fileTextInput(string fileName)
        {
            text = File.ReadAllText(fileName);
            return text;
        }
    }
}