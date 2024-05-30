namespace ArenaGame
{
    public class Arena
    {
        public Hero HeroA { get; private set; }
        public Hero HeroB { get; private set; }

        public Arena(Hero a, Hero b)
        {
            HeroA = a;
            HeroB = b;
        }

        public Hero Battle()
        {
            Hero attacker, defender;
            if (Random.Shared.Next(2) == 0)
            {
                attacker = HeroA;
                defender = HeroB;
            }
            else
            {
                attacker = HeroB;
                defender = HeroA;
            }
            while (true)
            {
                int damage = attacker.Attack();
                defender.TakeDamage(damage);
                Console.WriteLine($"{attacker.Name} hits {defender.Name} for {damage} damage. {defender.Name} has {defender.Health} health left.");
                if (defender.IsDead) return attacker;
                
                Hero tmp = attacker;
                attacker = defender;
                defender = tmp;
            }
        }

        public void RunRound(Hero[] heroes)
        {
            Random rng = new Random();
            int n = heroes.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Hero temp = heroes[k];
                heroes[k] = heroes[n];
                heroes[n] = temp;
            }

            for (int i = 0; i < heroes.Length; i += 2)
            {
                Console.WriteLine($"Arena fight between: {heroes[i].Name} and {heroes[i + 1].Name}");
                Arena arena = new Arena(heroes[i], heroes[i + 1]);
                Hero winner = arena.Battle();
                Console.WriteLine($"Winner is: {winner.Name}");
            }

            Console.WriteLine();
        }
    }
}
