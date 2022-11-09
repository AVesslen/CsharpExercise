using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn3
{
    abstract class UserError
    {
        public abstract string UEMessage(); //Abstract method  

    }

    class NumericInputError : UserError
    {
        public override string UEMessage()
        {
           return "You tried to use a numeric input in a text only field. This fired an error!";
        }       
    }


    class TextInputError:UserError
    {
        public override string UEMessage()
        {
           return "You tried to use a text input in a numeric only field. This fired an error!";
        }

    }

    class NegativeNumberInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a negative number input in a positive numeric only field. This fired an error!";
        }
    }

    class DoubleInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use an input of type double in an int only field. This fired an error!";
        }
    }

    class OutOfRangeInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use an input that is not in the valid range. This fired an error!";
        }
    }



}
