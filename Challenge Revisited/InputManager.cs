using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Revisited
{
    internal class InputManager
    {
        int boardDifficulty;
        bool validDifficulty = false;
        string input;
        int inputType;

        public int BoardDifficultyValidation()
        {
            while (!validDifficulty)
            {
                DifficultySelectPrompt();

                if (boardDifficulty == 1 || boardDifficulty == 2 || boardDifficulty == 3)
                {
                    validDifficulty = true;
                }
                else
                {
                    Console.WriteLine("You have entered an invalid input. Press any key to continue.");
                    Console.ReadKey();
                }
            }
            return boardDifficulty;
        }

        public void DifficultySelectPrompt()
        {
            int userSelection = 0;
            string rawInputText;
            Console.Write("Select difficulty level. Easy = 1, Medium = 2, Hard = 3: ");
            rawInputText = Console.ReadLine();
            boardDifficulty = (Int32.Parse(rawInputText));
        }

        public int GetBoardDifficulty()
        {
            return boardDifficulty;
        }

        public void SetBoardDifficulty(int input)
        {
            boardDifficulty = input;
        }

        public (int, int) PlayerMovement()
        {
            if (input.ToUpper() == "W")
            {
                return (0, 1);
            }
            else if (input.ToUpper() == "S")
            {
                return (0, -1);
            }
            else if (input.ToUpper() == "A")
            {
                return (-1, 0);
            }
            else if (input.ToUpper() == "D")
            {
                return (1, 0);
            }
            else
            {
                return (0, 0);
            }
        }

        //This handles all inputs and directs them to the appropriate method to perform;
        public void InputIntake()
        {
            if (input.ToUpper() == "W" || input.ToUpper() == "A" || input.ToUpper() == "S" || input.ToUpper() == "D")
            {
                PlayerMovement();
            }
        }

        //This will handle the type of input that was provided, and it will help feed the method that will trigger the specific type of action.
        public int GetInputType()
        {
            return inputType;
        }

    }
}
