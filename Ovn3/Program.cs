namespace Ovn3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person=PersonHandler.CreatePerson(20,"Anna","Vesslen",160,65);
           
            //try
            //{
            //    //person.Age = -2;
            //    PersonHandler.SetAge(person, 10);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //try
            //{
            //person.FName = "A";
                
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //try
            //{
            //person.LName = "Vessssssssleeeeeeeeeen";
                
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Console.WriteLine($"{person.FName}{person.LName}{person.Age}");
        }
    }
}