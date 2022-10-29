using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Revisited
{
    internal class GameSystem
    {
        //object intake
        public Board board;
        public Player player;

        //general game 
        bool playing = true;

        //these bools will serve as a check if the player is at a boundary of the board. 
        (bool,bool) boundLimit;

        //player system
        (int, int) playerPosition;
        (int, int) boardBoundaries;
        int playerHealth;
        int arrowCount;
               

        //monster system



        //class construtor
        public GameSystem()
        {
            board = new Board();
            player = new Player();
            playerPosition = player.GetPlayerPosition();
            board.GetBoundaries();
        }


        public void MoveUpdate() //this will run after each move to update the GameSystem values.
        {
            BoundaryCheck();
        }

        //checks the player's current position against the board's boundaries.
        void BoundaryCheck()
        {
            if (playerPosition.Item1 == 0 ||  playerPosition.Item1 == boardBoundaries.Item1)
            {
                boundLimit.Item1 = true;
            }
            else
            {
                boundLimit.Item1 = false;
            }

            if (playerPosition.Item2 == 0 || playerPosition.Item2 == boardBoundaries.Item2)
            {
                boundLimit.Item2 = true;
            }
            else
            {
                boundLimit.Item2 = false;
            }
        }


        //this will be used by the InputManager class to determine if the attempted move is within the board's boundaries.
        public (bool,bool) GetBoundaryCheck()
        {
            return boundLimit;
        }

        public bool GetPlaying()
        {
            return playing;
        }

        public void SetPlayerPosition((int,int) intake)
        {
            playerPosition = intake;
        }
    }
}
