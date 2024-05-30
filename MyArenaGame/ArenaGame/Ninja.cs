using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Ninja : Hero
    {
        private const int SmokeBombChance = 30;
        private const int SwiftStrikeChance = 20;
        private const int SwiftStrikeDamageMultiplier = 150;

        public Ninja(string name = "Shadow") : base(name) { }

        public override int Attack()
        {
            int attack = base.Attack();
            if (ThrowDice(SwiftStrikeChance))
            {
                attack = attack * SwiftStrikeDamageMultiplier / 100;
            }
            return attack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (ThrowDice(SmokeBombChance))
            {
                incomingDamage = 0;
            }
            base.TakeDamage(incomingDamage);
        }
    }
}
