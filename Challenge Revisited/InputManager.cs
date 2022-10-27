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

        public (int, int) PlayerMovement((bool, bool) playerBoundaryCheck)
        {

            if (input.ToUpper() == "W" && !playerBoundaryCheck.Item2)
            {
                return (0, 1);
            }
            else if (input.ToUpper() == "S" && !playerBoundaryCheck.Item2)
            {
                return (0, -1);
            }
            else if (input.ToUpper() == "A" && !playerBoundaryCheck.Item1)
            {
                return (-1, 0);
            }
            else if (input.ToUpper() == "D" && !playerBoundaryCheck.Item1)
            {
                return (1, 0);
            }
            else if (input.ToUpper() == "W" && playerBoundaryCheck.Item2 || input.ToUpper() == "S" && playerBoundaryCheck.Item2 ||
                input.ToUpper() == "A" && playerBoundaryCheck.Item1 || input.ToUpper() == "D" && playerBoundaryCheck.Item1)
            {
                Console.WriteLine("You are against a wall. You cannot make that move.");
                return (0, 0);
            }
            else
            {
                return (0, 0);
            }
        }

        //This handles all inputs and directs them to the appropriate method to perform;
        public void InputIntake((bool, bool) playerBoundaryCheck)//this will need to intake the GameSystem Function "GetBoundaryCheck" when called.
        {
            if (input.ToUpper() == "W" || input.ToUpper() == "A" || input.ToUpper() == "S" || input.ToUpper() == "D")
            {
                PlayerMovement(playerBoundaryCheck);
            }
        }

        //This will handle the type of input that was provided, and it will help feed the method that will trigger the specific type of action.
        public int GetInputType()
        {
            return inputType;
        }

    }
}
