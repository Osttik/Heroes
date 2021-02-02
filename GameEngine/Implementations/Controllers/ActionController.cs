using GameEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Implementations.Controllers
{
    public static class ActionController
    {
        public static List<IAction> Actions { get; set; } = new List<IAction>();

        static ActionController()
        {

        }
    }
}
