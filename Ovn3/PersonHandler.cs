using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ovn3
{
    internal class PersonHandler
    {
        
        public void SetAge(Person pers, int newAge)
        {
            pers.Age = newAge;          
        }

        public void SetFName(Person pers, string newFName)
        {
            pers.FName = newFName;
        }

        public void SetLName(Person pers, string newLName)
        {
            pers.LName = newLName;
        }

        public void SetHeight(Person pers, double newHeight)
        {
            pers.Height = (int)newHeight;
        }

        public void SetWeight(Person pers, double newWeight)
        {
            pers.Weight = (int)newWeight;
        }


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
