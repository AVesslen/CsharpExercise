namespace Ovn3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            try
            {
                person.Age = -2;               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
            person.FName = "A";
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
            person.LName = "Vessssssssleeeeeeeeeen";
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }




            Console.WriteLine($"{person.FName}{person.LName}{person.Age}");
        }
    }
}