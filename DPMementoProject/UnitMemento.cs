using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPMementoProject
{
    // Memento
    internal class UnitMemento
    {
        public int attack { get; private set; }
        public int damage { get; private set; }
        public UnitMemento(int attack, int damage)
        {
            this.attack = attack;
            this.damage = damage;
        }
    }
}
