using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                Console.Write(message);
                string numberText = Console.ReadLine();
                isInt = int.TryParse(numberText, out output);
                if (!isInt)
                    Console.WriteLine("That was not a valid input. Please try again.");
            }
            while (isInt == false);

            return output;
        }

    }
}
