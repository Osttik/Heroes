using GameEngine.Implementations;
using GameEngine.Implementations.Controllers;
using GameEnviroment.Helpers.Interfaces;
using GameEnviroment.Abstractions;
using GameEnviroment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEnviroment.Implementations
{
    public class Player : Hero, IUnit
    {
        private PlayerObject _playerObject;
        private KeyBoardController _controller;

        public IBackPack BackPack { get; set; }
        public Stats Stats { get; private set; }
        public IDescription Description { get; private set; }
        public List<IEffect> Effects { get; private set; }

        public Player()
        {
            Stats = new Stats();
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
