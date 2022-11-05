namespace Ovn2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            do
            {
                ShowMainMenu();
                string input = Console.ReadLine();

                switch (input.ToUpper())
                {
                    case "1":
                        int age = Customer.GetAge();
                        string personType = Customer.GetPersonType(age);
                        int price = Ticket.GetSinglePrice(age);
                        Ticket.PrintSingelTicket(personType, price);
                        break;

                    case "2":

                        int numberOfPeople = Customer.GetNumberOfPeople();
                        int totalPrice = Ticket.GetGroupPrice(numberOfPeople);
                        Ticket.PrintGroupTicket(numberOfPeople, totalPrice);
                        break;

                    case "3":
                        PlayWithStrings.RepeteText();
                        break;

                    case "4":
                        PlayWithStrings.ThirdWord();
                        break;

                    case "Q":
                        Environment.Exit(0);
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("That was not a valid input. Try again!");
                        break;
                }
            } while (isRunning == true);
        }

        private static void ShowMainMenu()
        {
            Console.WriteLine("This is the menu. Choose an option or type \"Q\" to quit.");
            Console.WriteLine("1. Youth or pensionair price");
            Console.WriteLine("2. Price for whole party ");
            Console.WriteLine("3. Repeat ten times ");
            Console.WriteLine("4. The third word");
        }
    }
}