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

        public Player()
        {
            playerPosition = (0, 0);
            playerPositionLimit = (0, 0);
        }

        public void PlayerMovement((int, int) moveInput)
        {
            if(playerPosition.Item1 + moveInput.Item1 !< 0 && playerPosition.Item1 + moveInput.Item1 !>playerPositionLimit.Item1 && playerPosition.Item2 + moveInput.Item2 !< 0 
                && playerPosition.Item2 + moveInput.Item2! > playerPositionLimit.Item2)
            {
                playerPosition.Item1 += moveInput.Item1;
                playerPosition.Item2 += moveInput.Item2;
            }
            else
            {
                Console.Write("Invalid Movmeent");
                Console.ReadKey();
            }
        }

        public void SetPlayerPositionLimit((int, int) boundary)
        {
            playerPositionLimit = boundary;
        }
    }
}
