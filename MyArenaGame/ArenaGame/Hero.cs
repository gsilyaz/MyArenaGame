namespace ArenaGame
{
    public class Hero
    {
        public string Name { get; private set; }

        public int Health { get; private set; }

        public int Strength { get; private set; }

        protected int StartingHealth { get; private set; }

        public bool IsDead { get { return Health <= 0; } }
        public Weapon EquippedWeapon { get; private set; }

        public Hero(string name)
        {
            Name = name;
            Health = 500;
            StartingHealth = Health;
            Strength = 100;

            EquipRandomWeapon();
        }

        public void EquipWeapon(Weapon weapon)
        {
            EquippedWeapon = weapon;
        }

        private void EquipRandomWeapon()
        {
            Random random = new Random();
            int weaponIndex = random.Next(3);
            switch (weaponIndex)
            {
                case 0:
                    EquipWeapon(new Katana());
                    break;
                case 1:
                    EquipWeapon(new Kunai());
                    break;
                case 2:
                    EquipWeapon(new Shuriken());
                    break;
                default:
                    EquipWeapon(new Katana());
                    break;
            }
        }

        public virtual int Attack()
        {
            int baseDamage = (Strength * Random.Shared.Next(80, 121)) / 100;
            if (EquippedWeapon != null)
            {
                baseDamage = EquippedWeapon.UniqueAbility(baseDamage);
            }
            return baseDamage;
        }

        public virtual void TakeDamage(int incomingDamage)
        {
            if (incomingDamage < 0) return;
            Health = Health - incomingDamage;
            if (Health < 0) Health = 0;
        }

        protected bool ThrowDice(int chance)
        {
            int dice = Random.Shared.Next(101);
            return dice <= chance;
        }

        protected void Heal(int value)
        {
            Health = Health + value;
            if (Health > StartingHealth) Health = StartingHealth;
        }
    }
}
