using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Implementations.Controllers
{
    public static class PositionController
    {

        public static void MoveUp(PlayerObject playerObject)
        {
            playerObject.Position.XPosition -= 1;
        }

        public static void MoveRight(PlayerObject playerObject)
        {
            playerObject.Position.YPosition += 1;
        }

        public static void MoveDown(PlayerObject playerObject)
        {
            playerObject.Position.XPosition += 1;
        }

        public static void MoveLeft(PlayerObject playerObject)
        {
            playerObject.Position.YPosition -= 1;
        }
    }
}
