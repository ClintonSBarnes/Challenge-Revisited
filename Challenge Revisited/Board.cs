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

        public Board()
        {
            boardDifficulty = 0;
        }

        public void BoardSelector()
        {
            if (boardDifficulty == 1)
            {
                BoardBuilder(easyBoardBoundary);
            }
            if (boardDifficulty == 2)
            {
                BoardBuilder(medBoardBoundary);
            }
            if (boardDifficulty == 3)
            {
                BoardBuilder(hardBoardBoundary);
            }
            else
            {
                Console.WriteLine("You have provided an invalid selection. Please select again.");
                BoardSelector();
            }
        }

        public void BoardBuilder(int input)
        {
            xBoundary = input;
            yBoundary = input;
        }

        public void SetBoardDifficulty(int difficulty)
        {
            boardDifficulty = difficulty;
        }

        public (int,int) GetBoundaries()
        {
            return (xBoundary, yBoundary);
        }
    }
}
