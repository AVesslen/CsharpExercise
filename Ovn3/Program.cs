namespace Ovn3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            NumericInputError numericInputError = new NumericInputError();
            NumericInputError numericInputError2 = new NumericInputError();
            TextInputError textInputError = new TextInputError();   
            NegativeNumberInputError negativeNumberInputError = new NegativeNumberInputError();
            DoubleInputError doubleInputError = new DoubleInputError(); 
            OutOfRangeInputError outOfRangeInputError = new OutOfRangeInputError();
            


            var list=new List<UserError>();
            list.Add(numericInputError);
            list.Add(numericInputError2);
            list.Add(textInputError);
            list.Add(negativeNumberInputError);
            list.Add(doubleInputError);
            list.Add(outOfRangeInputError);



            foreach(UserError error in list)
            {
                Console.WriteLine(error.UEMessage());
            }


























            //PersonHandler person1=PersonHandler.CreatePerson(20,"Anna","Vesslen",160,65);
           
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