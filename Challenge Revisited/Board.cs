using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Revisited
{
    internal class Board
    {
        int xBoundary = 0;
        int yBoundary = 0;
        int boardDifficulty;
        int easyBoardBoundary = 3;
        int medBoardBoundary = 5;
        int hardBoardBoundary = 8;

        bool validDifficulty = false;

        //class construtor
        public Board()
        {
            boardDifficulty = 0;
        }

        //initializes the board difficulty selection process, this calls three other functions in order to execute various portions of the process. 
        public void BoardBuilderAndValidation()
        {
            while (!validDifficulty)
            {
                DifficultySelectPrompt();

                if (boardDifficulty == 1 || boardDifficulty == 2 || boardDifficulty == 3)
                {
                    validDifficulty = true;
                    SetBoardDifficulty(boardDifficulty);
                    BoardSelector();
                }
                else
                {
                    Console.WriteLine("You have entered an invalid input. Press any key to continue.");
                    Console.ReadKey();
                }
            }
        }

        //this is the first step in the board difficulty/buidling process. 
        //this reads prompts the user and converts the string input to an int.
        public void DifficultySelectPrompt()
        {
            int userSelection = 0;
            string rawInputText;
            Console.Write("Select difficulty level. Easy = 1, Medium = 2, Hard = 3: ");
            rawInputText = Console.ReadLine();
            boardDifficulty = (Int32.Parse(rawInputText));
        }

        //saves the board difficulty variable value.
        public void SetBoardDifficulty(int difficulty)
        {
            boardDifficulty = difficulty;
        }

        //this determines the size of the board to feed the construction of the boundaries.
        public void BoardSelector()
        {
            if (boardDifficulty == 1)
            {
                BoardConstructionUpdate(easyBoardBoundary);
            }
            if (boardDifficulty == 2)
            {
                BoardConstructionUpdate(medBoardBoundary);
            }
            if (boardDifficulty == 3)
            {
                BoardConstructionUpdate(hardBoardBoundary);
            }

        }

        //sets the the boundaries of the board. 
        public void BoardConstructionUpdate(int input)
        {
            xBoundary = input;
            yBoundary = input;
        }


        //Getter fucitons
        public (int, int) GetBoundaries()
        {
            return (xBoundary, yBoundary);
        }

        public int GetBoardDifficulty()
        {
            return boardDifficulty;
        }
    }
}


//THIS CLASS IS CURRENTLY IN A COMPLETED STATE.
//The purpose of this class is to intake the game's difficulty setting and create the board's outermost boundaries. 
