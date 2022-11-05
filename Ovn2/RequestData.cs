using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ovn2
{
    internal class RequestData
    {
        public static int AskForInt(string message)
        {
            bool isInt = false;
            int output;

            do
            {
                Console.WriteLine(message);
                string numberText = Console.ReadLine();
                isInt = int.TryParse(numberText, out output);
                if (!isInt)
                    Console.WriteLine("That was not a valid input. Please try again.");
            }
            while (isInt == false);

            return output;
        }

        public static string AskForSentence(string message)  //Asks for a sentence with at least 3 words
        {
            bool isLongEnough;
            string inputSentence;
            do
            {
                Console.WriteLine(message);
                inputSentence = Console.ReadLine();
                inputSentence = Regex.Replace(inputSentence, @"\s+", " "); //Captures multiple white spaces
                inputSentence = inputSentence.Trim();  //Removes all leading and trailing white spaces 

                int count = Regex.Matches(inputSentence, @"[\S]+").Count;
                if (count >= 3)
                {
                    isLongEnough = true;
                    break;
                }
                else
                {
                    Console.WriteLine("That sentence was too short. Try again.");
                    isLongEnough = false;
                }
            }
            while (isLongEnough==false);
            return inputSentence;
        }




    }
}
