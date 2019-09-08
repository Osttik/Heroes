using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.GameEngine.Implementations.Controllers
{
    public class KeyBoardController
    {
        public void Move(PlayerObject playerObject)
        {
            if (Console.KeyAvailable)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.W:
                        PositionController.MoveUp(playerObject);
                        break;
                    case ConsoleKey.S:
                        PositionController.MoveDown(playerObject);
                        break;
                    case ConsoleKey.D:
                        PositionController.MoveRight(playerObject);
                        break;
                    case ConsoleKey.A:
                        PositionController.MoveLeft(playerObject);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
