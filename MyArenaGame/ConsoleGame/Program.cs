using ArenaGame;
using System;

namespace ConsoleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero[] heroes = {
            new Knight("Sir Lancelot"),
            new Rogue("Robih Hood"),
            new Ninja("Kakashi Hatake"),
            new Druid("Baba Yaga")
            };

            foreach (var hero in heroes)
            {
                Console.WriteLine($"{hero.Name} equipped with {hero.EquippedWeapon.Name}");
            }

            Console.WriteLine();

            Arena arena = new Arena(null, null);

            // First Round
            Console.WriteLine("First Round:");
            Console.WriteLine();
            arena.RunRound(heroes);

            // Winners of the first round
            Hero[] winners = new Hero[2];
            Array.Sort(heroes, (x, y) => x.Health.CompareTo(y.Health));
            winners[0] = heroes[heroes.Length - 1];
            winners[1] = heroes[heroes.Length - 2];

            // Final Round
            Console.WriteLine("Final Round:");
            Console.WriteLine();
            arena.RunRound(winners);

            Console.ReadLine();
        }
    }
}
