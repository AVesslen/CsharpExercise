using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn2
{
    internal class Ticket
    {

        public static void PrintSingelTicket(string personType, int price)
        {
            Console.WriteLine($"{personType} price: {price} kr");
        }

        public static void PrintGroupTicket(int numberOfPeople, int totalPrice)
        {
            Console.WriteLine($"The total price for {numberOfPeople} persons: {totalPrice} kr");
        }

        public static int GetSinglePrice(int age)
        {
            int price;

            if (age < 20)
                price = 80;

            else if (age > 64)
                price = 90;

            else
                price = 120;

            return price;

        }

        public static int GetGroupPrice(int numberOfPeople)
        {
            int price = 0;
            int totalPrice = 0;
            int age = 0;
            for (int i = 1; i <= numberOfPeople; i++)
            {
                age = RequestData.AskForInt($"What's the age of person {i}? ");
                price = GetSinglePrice(age);
                totalPrice = totalPrice + price;
            }
            return totalPrice;
        }

    }
}
