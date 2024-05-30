using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Kunai : Weapon
    {
        public Kunai() : base("Kunai", 15) { }

        public override int UniqueAbility(int baseDamage)
        {
            if (Random.Shared.Next(100) < 40)
            {
                return (baseDamage + AttackPower) * 2;
            }
            return baseDamage + AttackPower;
        }
    }
}
