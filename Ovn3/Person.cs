using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn3
{
    internal class Person
    {
        private int age;
        private string fName;
        private string lName;
        //private int height;
        //private int weight;

        public int Height { get; set; }
        public int Weight { get; set; }
                       

        public string FName
        {
            get 
            { 
                return fName; 
            }
            set 
            {
                if (value.Length >= 2 && value.Length <= 10)
                    fName = value;
                else
                    throw new ArgumentException("Length of first name needs to be in a valid range");
            }
        }

        public string LName
        {
            get
            {
                return lName;
            }
            set
            {
                if (value.Length <= 3 && value.Length <= 15)
                    lName = value;
                else
                    throw new ArgumentException("Length of last name needs to be in a valid range");
            }
        }

        public int Age
        {
            get 
            { 
                return age; 
            }
            set 
            {
                if (value > 0)
                    age = value;
                else
                    throw new ArgumentException ("Age needs to be >0");                
            }
        }

       



    }
}
