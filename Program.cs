using System;

namespace EpicFight
{
    class Program
    {
        static void Main(string[] args)
        {
            string hero = PickHero();
            string villain = PickVillain();
            int HeroHP = GenerateHP(hero);
            int villainHP = GenerateHP(villain);

            Console.WriteLine($"{hero} will fight {villain}.");

            string heroWeapon = PickWeaponHero();
            string villainWeapon = PickWeaponVillain();
            Console.WriteLine($"{hero} picked {heroWeapon}. {villain} picked {villainWeapon}.");

            while(HeroHP > 0 && villainHP > 0)
            {
                HeroHP = HeroHP - Hit(villain, hero, villainWeapon);
                villainHP = villainHP - Hit(hero, villain, heroWeapon);
            }

            if(HeroHP <= 0)
            {
                Console.WriteLine("Dark side wins!");
            }
            else
            {
                Console.WriteLine($"{hero} saves the day!");
            }

        }
        private static int Hit(string CharacterOne, string CharacterTwo, string someWeapon)
        {
            Random rnd = new Random();
            int strike = rnd.Next(0, someWeapon.Length / 2);

            Console.WriteLine($"{CharacterOne} hit {strike}.");

            if(strike == someWeapon.Length / 2)
            {
                Console.WriteLine($"Awesome! {CharacterOne} made a critical hit!");
            }
            else if(strike == 0)
            {
                Console.WriteLine($"{CharacterTwo} dodged the attack!");
            }

            return strike;
        }

        private static int GenerateHP(string someName)
        {
            Random rnd = new Random();
            return rnd.Next(someName.Length, someName.Length + 10);
        }
        private static string PickHero()
        {
            string[] superHeroes = { "Batman", "Spiderman", "Spongebob", "Mike Wazovski" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, superHeroes.Length);

            return superHeroes[randomIndex];
        }
        private static string PickVillain()
        {
            string[] villain = { "Joker", "Darth Vader", "Ahmed", "Hitler", "Thanos" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, villain.Length);

            return villain[randomIndex];
        }
        private static string PickWeaponHero()
        {
            string[] heroWeapon = {"kööginuga", "kaka", "klaaspudeli põhi", "Nuclear Bomb"};
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, heroWeapon.Length);

            return heroWeapon[randomIndex];
        }
        private static string PickWeaponVillain()
        {
            string[] villainWeapon = { "Saw", "Klaviatuur", "rusikad", "banana" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, villainWeapon.Length);

            return villainWeapon[randomIndex];
        }



    }
}
