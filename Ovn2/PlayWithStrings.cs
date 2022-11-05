using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn2
{
    public class PlayWithStrings
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
        }

        public static void ThirdWord()
        {
            Console.WriteLine("Write a sentence with at least 3 words: ");
            string inputSentence = Console.ReadLine();
            var sentenceSplit = inputSentence.Split(' ');
            Console.WriteLine($"The third word is: {sentenceSplit[2]}");
        }

    }
}
