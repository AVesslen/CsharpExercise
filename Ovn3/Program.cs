using System;

namespace Ovn3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            
            
            Horse horse = new Horse();
            horse.DoSound();
            Pelican pelican = new Pelican();
            pelican.NumberOfFeathers = 100;
            Bird bird = new Bird();
            bird.NumberOfFeathers = 200;
            
            Console.WriteLine(pelican.NumberOfFeathers);
            
            
            
            
            // **** Uppgift 3.2 Polymorfism ****
            //
            //NumericInputError numericInputError = new NumericInputError();
            //NumericInputError numericInputError2 = new NumericInputError();
            //TextInputError textInputError = new TextInputError();   
            //NegativeNumberInputError negativeNumberInputError = new NegativeNumberInputError();
            //DoubleInputError doubleInputError = new DoubleInputError(); 
            //OutOfRangeInputError outOfRangeInputError = new OutOfRangeInputError();


            //var list=new List<UserError>();
            //list.Add(numericInputError);
            //list.Add(numericInputError2);
            //list.Add(textInputError);
            //list.Add(negativeNumberInputError);
            //list.Add(doubleInputError);
            //list.Add(outOfRangeInputError);

            //foreach(UserError error in list)
            //{
            //    Console.WriteLine(error.UEMessage());
            //}




          
            // **** Uppgift 3.1.5. **** Inkapsling PersonHandler
            //
            //PersonHandler personHandler = new PersonHandler();
            //Person person= personHandler.CreatePerson(age:35, fname:"Maria", lname:"Karlsson", 170.3, 65);
            //Console.WriteLine($"Before changing: {person.FName} {person.LName} {person.Age} years {person.Height} cm {person.Weight} kg");
                        
            //personHandler.SetAge(person, 55);
            //personHandler.SetHeight(person,155);
            //personHandler.SetLName(person, "Smith");
            //Console.WriteLine($"After changing:{person.FName } {person.LName} { person.Age} years {person.Height} cm {person.Weight} kg");


            //PersonHandler personHandler2 = new PersonHandler();
            //Person person2 = personHandler2.CreatePerson(age: 5, fname: "Kalle", lname: "Svensson", 180, 91.6);
            //Console.WriteLine($"Before changing: {person2.FName} {person2.LName} {person2.Age} years {person2.Height} cm {person2.Weight} kg");
           
            //personHandler.SetAge(person2, 70);
            //personHandler.SetFName(person2, "Erik");
            //personHandler.SetWeight(person2, 75);      
            //Console.WriteLine($"After changing: {person2.FName} {person2.LName} {person2.Age} years {person2.Height} cm {person2.Weight} kg");

                                 



            // **** Uppgift 3.1.1 *****   Inkapsling
            //
            // Person person=new Person();
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