using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Revisited
{
    internal class InputManager
    {
        string input;
        int inputType;

        



        //This will handle the type of input that was provided, and it will help feed the method that will trigger the specific type of action.
        public int GetInputType()
        {
            return inputType;
        }

    }
}
