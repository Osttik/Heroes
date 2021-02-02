using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Implementations.Controllers
{
    public class MapController
    {
        private List<PlayerObject> _players { get; set; }

        public MapController()
        {
            _players = new List<PlayerObject>();
        }

        public void AddPlayer(PlayerObject playerObject)
        {
            _players.Add(playerObject);
        }

        public void RemovePlayer(PlayerObject playerObject)
        {
            _players.Remove(playerObject);
        }

        public PlayerObject GetPlayerByPosition(int x, int y)
        {
            foreach (var player in _players)
            {
                if (player.Position.XPosition == x && player.Position.YPosition == y)
                {
                    return player;
                }
            }

            return new PlayerObject();
        }
    }
}
