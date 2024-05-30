using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Druid : Hero
    {
        private const int NatureBlessingHealAmount = 40;
        private const int ElementalStrikeChance = 30;
        private const int ElementalStrikeMinDamage = 20;
        private const int ElementalStrikeMaxDamage = 50;
        private const int HealChance = 50;

        public Druid(string name = "Elowen") : base(name) { }

        public override int Attack()
        {
            int attack = base.Attack();
            if (ThrowDice(ElementalStrikeChance))
            {     
                attack += Random.Shared.Next(ElementalStrikeMinDamage, ElementalStrikeMaxDamage + 1);
            }
            return attack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            base.TakeDamage(incomingDamage);
            if (ThrowDice(HealChance))
            {
                Heal(NatureBlessingHealAmount);   
            }
        }
    }
}
