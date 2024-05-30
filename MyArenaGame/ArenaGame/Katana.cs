using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Katana : Weapon
    {
        public Katana() : base("Katana", 25) { }

        public override int UniqueAbility(int baseDamage)
        {
            if (Random.Shared.Next(100) < 25)
            {
                return (baseDamage + AttackPower) * 2;
            }
            return baseDamage + AttackPower;
        }
    }
}
