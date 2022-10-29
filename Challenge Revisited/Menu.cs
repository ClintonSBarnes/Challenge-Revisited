using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Revisited
{
    internal class Menu
    {

        (int, int) playersPosition;


        public void RetrievePlayerPosition((int, int) position)
        {
            playersPosition = position;
        }

        public void PlayerPositionDeclaration((int, int) currentPlayerPosition) //currentPlayerPosition must be called from the Player class.
        {
            Console.WriteLine($"You are current standing on tile {currentPlayerPosition}.");
        }

        public void NextMovePrompt()
        {
            PlayerPositionDeclaration(playersPosition);
            Console.WriteLine("What will your next move be?");
        }

    }
}
