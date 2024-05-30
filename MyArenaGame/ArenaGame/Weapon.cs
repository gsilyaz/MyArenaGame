using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public abstract class Weapon
    {
        public string Name { get; protected set; }
        public int AttackPower { get; protected set; }

        public Weapon(string name, int attackPower)
        {
            Name = name;
            AttackPower = attackPower;
        }

        public abstract int UniqueAbility(int baseDamage);
    }
}
