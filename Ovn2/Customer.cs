using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Ovn2
{
    internal class Customer
    {

        public static int GetAge()
        {
            int age = RequestData.AskForInt("What is your age? ");
            return age;
        }

        public static string GetPersonType(int age)
        {
            string personType;
            if (age < 5)
                personType = "Child";

            else if (age >= 5 && age < 20)
                personType = "Youth";

            else if (age > 64 && age <= 100)
                personType = "Pensionair";

            else if (age > 100)
                personType = "100+";

            else
                personType = "Standard";

            return personType;
        }

        public static int GetNumberOfPeople()
        {
            int numberOfPeople = RequestData.AskForInt("How many people are in your party? ");
            return numberOfPeople;
        }

    }
}
