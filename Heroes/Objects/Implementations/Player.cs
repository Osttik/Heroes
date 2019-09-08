using Heroes.GameEngine.Implementations;
using Heroes.GameEngine.Implementations.Controllers;
using Heroes.Objects.Abstractions;
using Heroes.Objects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.Objects.Implementations
{
    public class Player : Hero, IUnit
    {
        private PlayerObject _playerObject;
        private KeyBoardController _controller;

        public IBackPack BackPack { get; set; }

        public Player()
        {
            _playerObject = new PlayerObject();
            _controller = new KeyBoardController();
        }

        public void StartControl()
        {
            _controller.Move(_playerObject);
        }

        public void MoveToMap(string mapName, int x, int y)
        {
            _playerObject.MoveToMap(mapName, x, y);
        }
    }
}
