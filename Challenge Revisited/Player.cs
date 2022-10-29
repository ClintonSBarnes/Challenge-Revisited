using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Revisited
{
    internal class Player
    {
        (int, int) playerPosition;
        (int, int) playerPositionLimit;
        string input;
        int inputType;
        (bool, bool) boundaryCheck;

        public Player()
        {
            playerPosition = (0, 0);
            playerPositionLimit = (0, 0);
        }



        public void PlayerMoveFunctions()
        {
            InputIntake(boundaryCheck);
        }


        //This handles all inputs and directs them to the appropriate method to perform;
        public void InputIntake((bool, bool) playerBoundaryCheck)//this will need to intake the GameSystem Function "GetBoundaryCheck" when called.
        {

            input = Console.ReadLine();

            if (input.ToUpper() == "W" || input.ToUpper() == "A" || input.ToUpper() == "S" || input.ToUpper() == "D")
            {
                playerPosition.Item1 +=  PlayerMovement(playerBoundaryCheck).Item1;
                playerPosition.Item2 += PlayerMovement(playerBoundaryCheck).Item2;


            }
        }


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


        public void SetPlayerPositionLimit((int, int) boundary)
        {
            playerPositionLimit = boundary;
        }

        public (int,int) GetPlayerPosition()
        {
            return playerPosition;
        }

        public void SetBoundaryCheck((bool, bool) fromGameSystem)
        {
            boundaryCheck = fromGameSystem;
        }
    }
}
