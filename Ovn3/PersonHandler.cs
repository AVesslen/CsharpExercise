using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn3
{
    internal class PersonHandler
    {
        //public void SetAge(Person pers, int newage)
        //{
        //    pers.Age = newage;
        //}


        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person person = new Person();
            person.Age = age;
            person.FName = fname;
            person.LName = lname;
            person.Height = (int)height;
            person.Weight=(int)weight;
            return person;

        }

    }
}
