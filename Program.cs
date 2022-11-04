namespace Ovn1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "";
            string lastName = "";
            int salary = 0;
            string answer = "";


            var firstNames = new List<string>();
            var lastNames = new List<string>();
            var salaries=new List<int>();


            do
            {
                Console.WriteLine("What is your first name? ");
                firstName = Console.ReadLine();
                firstNames.Add(firstName);

                Console.WriteLine("What is your last name? ");
                lastName = Console.ReadLine();
                lastNames.Add(lastName);

                Console.WriteLine("What is your salary? ");
                salary = int.Parse(Console.ReadLine());  //Assumes that the user answers with numbers, and not letters

                if (salary<0)  //Checking for negative numbers
                {
                    Console.WriteLine("That was not a valid number. Try again!");
                    Console.WriteLine("What is your salary? ");
                    salary = int.Parse(Console.ReadLine());  
                }

                salaries.Add(salary);


                Console.WriteLine("Do you want to add another person? (yes/no) ?");
                answer = Console.ReadLine();

                if (answer.ToLower()!="yes" && answer.ToLower()!="no")  //Checking for unvalid choises
                    {
                    Console.WriteLine("That was not a correct answer. Dou you want to add another person (yes/no)?");
                    answer = Console.ReadLine();
                }

            }
            while (answer.ToLower() == "yes");


            for (int i = 0; i < firstNames.Count; i++)
            {
                Console.WriteLine($"Name: {firstNames[i]} {lastNames[i]}    Salary: {salaries[i]} kr");
            }


        }
    }
}