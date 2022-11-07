using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;



namespace Ovn2
{
    public class PlayWithStrings //String manipulations
    {
        public static void RepeteText()
        {
            Console.WriteLine("Write any text: ");
            string inputText = Console.ReadLine();
            int numberOfRepeats = 10;

            for (int i = 1; i <= numberOfRepeats; i++)
            {
                Console.Write($"{i}.{inputText}, ");
            }
            Console.WriteLine();
        }

        public static void PrintThirdWord()
        {            
            string inputSentence= RequestData.AskForSentence("Write a sentence with at least 3 words: ");
            //Checks that the sentence contains at least three words

            var sentenceSplit = inputSentence.Split(' ');
            Console.WriteLine($"The third word is: {sentenceSplit[2]}");
        }   

    }
}
