using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPMementoProject
{
    // Originator
    internal class Unit
    {
        private int attack;
        private int damage;

        public Unit()
        {
            attack= 50;
            damage= 50;
        }
        public void Fire()
        {
            attack += 2;
            damage--;
            Console.WriteLine($"Current unit attak{attack}, damage{damage}");
        }

        public UnitMemento Save()
        {
            Console.WriteLine($"Save game unit attak{attack}, damage{damage}");
            return new UnitMemento(attack, damage);
        }

        public void Load(UnitMemento memento)
        {
            this.attack = memento.attack;
            this.damage = memento.damage;
            Console.WriteLine($"Load game unit attak{attack}, damage{damage}");
        }
    }
}
