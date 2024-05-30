using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Shuriken : Weapon
    {
        public Shuriken() : base("Shuriken", 10) { }

        public override int UniqueAbility(int baseDamage)
        {
            if (Random.Shared.Next(100) < 20)
            {
                return (baseDamage + AttackPower) / 2 * 3;
            }
            return baseDamage + AttackPower;
        }
    }
}
