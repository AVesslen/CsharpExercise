using System;

namespace Ovn3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Horse horse = new Horse();
            //horse.Name = "Ronja";
            //horse.Age = 12;
            //horse.Weight = 500;
            //horse.HoofSize = 6;

            //Hedgehog hedgehog = new Hedgehog();
            //hedgehog.Name = "Igge";
            //hedgehog.Age = 2;
            //hedgehog.Weight = 1.5;
            //hedgehog.NumberOfSpikes = 200;

            //Pelican pelican = new Pelican();
            //pelican.Name = "Pippi";
            //pelican.Age = 4;
            //pelican.Weight = 15;
            //pelican.NumberOfFeathers = 300;
            //pelican.WingSpan = 250;
            //pelican.BeakSize = 25;

            //Wolfman wolfman = new Wolfman();
            //wolfman.Name = "Kalle";

            //Dog dog = new Dog();
            //dog.Name = "Fido";
            //dog.Age = 5;
            //dog.FurColor = "White";

            //Dog dog2 = new Dog();
            //dog2.Name = "Laban";
            //dog2.Age = 10;
            //dog2.FurColor = "Brown";          

            //List<Animal> Animals = new List<Animal>
            //{
            //    horse, hedgehog,pelican, wolfman, dog, dog2
            //};

            //foreach (Animal animal in Animals)
            //{
            //    Console.WriteLine(animal);
            //    Console.WriteLine(animal.Stats());
            //    if (animal is IPerson)
            //    {
            //        IPerson castedWolfman = (IPerson)animal;     //Type casting
            //        Console.WriteLine(castedWolfman.Talk());
            //    }
            //    else
            //        Console.WriteLine(animal.DoSound());

            //    Console.WriteLine();
            //}

            //List<Dog> Dogs = new List<Dog>();
            //Dogs.Add(horse);               //// Fråga 3.4.9: Kan ej lägga till horse. Listan kan bara innehålla instanser av typ Dog. Horse är ingen subklass till Dog.
            //// Fråga 3.4.10: För att alla klasser ska kunna lagras tillsammans måste listan vara av typ Animal


            //foreach (Animal animal in Animals)
            //{
            //    Console.WriteLine(animal);                 ////Fråga 3.4.13. Den virtuella metoden Stats() tillåter att subklasserna ersätter den med en egen, override.
            //    Console.WriteLine(animal.Stats());         ////   Vid anrop av animal.Stats() hanteras subklasserna som instanser av deras basklasser. 
            //    Console.WriteLine();                       ////   Den mest specialiserade metoden kommer då användas. (enl. Polymorfismens regel 1+2). 
            //}

            //foreach (Animal animal in Animals)
            //{
            //    if (animal is Dog dogs)  // castar direkt
            //    {
            //        Console.WriteLine(animal.Stats());
            //        Console.WriteLine(dogs.Eat());              //// Fråga 3.4.17. Jag kommer inte åt Eat()-metoden från Animals-listan                                           
            //    }                                               //// eftersom metoden inte finns i Animal-klassen. Dog ärver klassen Animal, 
            //}                                                   //// men Animal har ingen koll på vad som sker i Dog.
                
                
            



            //Pelican pelican = new Pelican();
            //pelican.Age = 2;
            //pelican.Name = "Pippi";
            //pelican.WingSpan = 3;
            //pelican.BeakSize = 10;
            //Horse horse = new Horse();
            //string egenskaper=pelican.Stats();

            //Console.WriteLine(egenskaper);

            //Horse horse = new Horse();
            //horse.DoSound();
            //Pelican pelican = new Pelican();
            //pelican.NumberOfFeathers = 100;
            //Bird bird = new Bird();
            //bird.NumberOfFeathers = 200;

            //Console.WriteLine(pelican.NumberOfFeathers);




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
            //Person person = personHandler.CreatePerson(age: 35, fname: "Maria", lname: "Karlsson", 170.3, 65);
            //Console.WriteLine($"Before changing: {person.FName} {person.LName} {person.Age} years {person.Height} cm {person.Weight} kg");

            //personHandler.SetAge(person, 55);               
            //personHandler.SetHeight(person, 155);
            //personHandler.SetLName(person, "Smith");
            //Console.WriteLine($"After changing:{person.FName} {person.LName} {person.Age} years {person.Height} cm {person.Weight} kg");


            //PersonHandler personHandler2 = new PersonHandler();
            //Person person2 = personHandler2.CreatePerson(age: 5, fname: "Kalle", lname: "Svensson", 180, 91.6);
            //Console.WriteLine($"Before changing: {person2.FName} {person2.LName} {person2.Age} years {person2.Height} cm {person2.Weight} kg");

            //personHandler.SetAge(person2, 70);
            //personHandler.SetFName(person2, "Erik");
            //personHandler.SetWeight(person2, 75);
            //Console.WriteLine($"After changing: {person2.FName} {person2.LName} {person2.Age} years {person2.Height} cm {person2.Weight} kg");



            //****Uppgift 3.1.1 * ****Inkapsling

            // Person person = new Person();
            //try
            //{
            //    person.Age = -2;                
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //try
            //{
            //    person.FName = "A";
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //try
            //{
            //    person.LName = "Vessssssssleeeeeeeeeen";
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Console.WriteLine($"{person.FName}{person.LName}{person.Age}");
        }
    }
}