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
            //Bool used for continuing the program after a choise.
            bool continuepar = false;

            //Create 'Input' object
            //Get either manually entered text, or text from a file
            
            //Promps user to choose between 1 and 2
            Console.WriteLine("Which input would you like to choose?\nType in '1' for text input\nType in '2' for an already located file input");
            Console.WriteLine("Please Choose: ");
            do
            {
                string answerOption = Console.ReadLine(); //Reads input

                switch (answerOption)
                {
                    // A basic UI that allows the use to select between using a file
                    // taking the text input directly
                    case "1":
                        continuepar = true; //Tells the program to continue
                        Input.manualTextInput();
                        break;
                    case "2":
                        Console.WriteLine("Reading File: CMP1903M Assessment 1 Test File.txt\n");
                        Console.WriteLine(Input.fileTextInput("CMP1903M Assessment 1 Test File.txt"));
                        string input = Input.fileTextInput("CMP1903M Assessment 1 Test File.txt");

                        //Any word longer than 7 letters gets put on a new "longwords.txt" file
                        string fileContents = File.ReadAllText("CMP1903M Assessment 1 Test File.txt");
                        var result = fileContents.Split(' ', ';', ',', '.', ':').Where(x => x.Length >= 8);

                        if (File.Exists(@"Long Words.txt"))
                        {
                            File.Delete(@"Long Words.txt");
                        }
                        string path = "Long Words.txt"; //Creates file
                        
                        //Prints list of words longer than 7 letters
                        
                        using (StreamWriter sw = File.AppendText(path))
                        {
                            
                            sw.WriteLine("List of all words 8 letters or more: \n");
                            foreach (var word in result)
                            {
                                sw.WriteLine(word);
                            }
                        }
                        Console.WriteLine("\nCreated a new file: 'Long Words.txt");

                        Analyse.analyseText(input);
                        break; 
                    default:
                        Console.WriteLine("Invalid answer. Please enter 1 or 2.");
                        break;
                }

            } while (continuepar == false); //Tells the program to repeat the question
        }
    }
}