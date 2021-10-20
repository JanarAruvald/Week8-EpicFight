using System;

namespace EpicFight
{
    class Program
    {
        static void Main(string[] args)
        {
            string hero = PickHero();
            string villain = PickVillain();
            Console.WriteLine($"{hero} will fight {villain}.");

            string heroWeapon = PickWeapon();
            string villainWeapon = PickWeapon();
            Console.WriteLine($"{hero} picked {heroWeapon}. {villain} picked {villainWeapon}.");
        }
        private static string PickHero()
        {
            string[] superHeroes = { "Luke Skywalker", "Batman", "Spiderman", "Spongebob", "Mike Wazovski" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, superHeroes.Length);

            return superHeroes[randomIndex];
        }
        private static string PickVillain()
        {
            string[] villain = { "Joker", "Darth Vader", "Voldemort", "Hitler", "Thanos" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, villain.Length);

            return villain[randomIndex];
        }
        private static string PickWeapon()
        {
            string[] heroWeapon = {"kööginuga", "kummipeenis", "auto", "Nuclear Bomb" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, heroWeapon.Length);

            return heroWeapon[randomIndex];

            string[] villainWeapon = {"Saw", "Klaviatuur"};
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, villainWeapon.Length);

            return villainWeapon[randomIndex];

        }




    }
}
