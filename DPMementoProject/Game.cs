using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPMementoProject
{
    // Caretaker
    internal class Game
    {
        public Stack<UnitMemento> Games { get; private set; }

        public Game() 
        {
            Games = new();
        }
    }
}
