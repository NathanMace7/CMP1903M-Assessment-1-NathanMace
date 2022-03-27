using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)
        public static void outputConsole(int sentenceCount, int charCount, int vowelCount,int consCount, int upperCount, int lowerCount, int numCount, int symbCount, int spaceCount,int totalCharCount)//List<int>
        {
            //List of integers to hold the first five measurements:
            //Creates a space
            Console.WriteLine("\n*The below doesn't include punctuation or whitespaces between words.\n");
            //1. number of sentences
            Console.WriteLine("Number of sentences: " + sentenceCount);
            //2. number of characters
            Console.WriteLine("Number of characters: " + charCount);
            //3. number of vowels
            Console.WriteLine("Number of vowels: " + vowelCount);
            //4. number of consonants
            Console.WriteLine("Number of consonants: " + consCount);
            //5. number of upper case letters
            Console.WriteLine("Number of upper case letters: " + upperCount);
            //6. number of lower case letters
            Console.WriteLine("Number of lower case letters: " + lowerCount);
            //7. Number of numbers
            Console.WriteLine("Number of numbers: " + numCount);
            //8. Number of symbols
            Console.WriteLine("\n*The below does include punctuation or whitespaces between words.\n");
            Console.WriteLine("Number of symbols: " +  symbCount);
            //9. Number of spaces
            Console.WriteLine("Number of spaces: " + spaceCount);
            //10. number of total characters
            Console.WriteLine("Number of total characters: " + totalCharCount);
            System.Environment.Exit(0);

            //Promps User to exit
            Console.WriteLine("Please press Enter (↩) to exit");
            Console.ReadLine();
        }
    }
}
