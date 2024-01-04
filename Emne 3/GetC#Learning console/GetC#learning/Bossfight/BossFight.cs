

using System.Net.Http.Headers;

namespace Emne3.Bossfight
{
    internal class BossFight
    {
        //creating the characters
        static GameCharacter Hero = new(100, 40, 20);
        static GameCharacter Boss = new(200, 10);
        internal static void Start()
        {
            //clearing and starting
            Console.Clear();
            Console.SetCursorPosition(0, 3);

            Console.WriteLine("this is a simulation of a Bossfight");
            Console.ReadLine();

            //starting the simulation
            Console.Clear();
            Console.SetCursorPosition(0, 3);

            //showing of Hero and boss for simulation
            ShowCharacters();

            //pause to read stats
            Console.ReadLine();

            //clearing to keep the console readable
            Console.Clear();
            Console.SetCursorPosition(0, 3);

            //the fight
            while (Hero.Health() > 0 && Boss.Health() > 0)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 3);

                var (hero, boss) = Fight();

                //to better se the change i added a sligt sleep
                Thread.Sleep(200);

                //showing the result of the bout   
                ShowCharacters();
                ItterationResult(hero, boss);

                //just a small pause       
                Console.WriteLine("\n\n\npress enter to continue");
                Console.ReadLine();
            }
            //clearing console to announce winner
            Console.Clear();
            Console.SetCursorPosition(0, 3);

            //anouncing winner
            Winner();


            Console.ReadLine();
        }

        private static void ShowCharacters()
        {
            var (HeroHealth, HeroStamina, HeroStrength, HerostrRandom) = Hero.show();
            var (BossHealth, BossStamina, BossStrength, BossStrRandom) = Boss.show();
            Console.WriteLine($"Hero\n" +
                              $"Health:         {HeroHealth}\n" +
                              $"Stamina:        {HeroStamina}\n" +
                              $"Strength:       {HeroStrength}\n" +
                              $"Random damage?  {HerostrRandom}\n");

            Console.WriteLine($"Boss:\n" +
                              $"Health:         {BossHealth}\n" +
                              $"Stamina:        {BossStamina}\n" +
                              $"Strength:       {BossStrength}\n" +
                              $"Random damage?  {BossStrRandom}\n");
        }

        private static void Winner()
        {
            int result = determinewinner();

            string winner = result switch
            {
                1 => "the Hero Dies, and the Boss continues his bossing, the people was not amused",
                2 => "Victory! the hero Has Slain the Boss, the people did not care",
                3 => "The Hero and the Boss both died, and the people cheered",
                _ => @" ¯\_(ツ)_/¯ "
            };

            Console.WriteLine($"{winner}");

        }

        private static int determinewinner()
        {
            var heroHealth = Hero.Health();
            var bossHealth = Boss.Health();
            if (heroHealth <= 0 && bossHealth > 0) return 1;
            if (heroHealth > 0 && bossHealth <= 0) return 2;
            if (heroHealth <= 0 && bossHealth <= 0) return 3;
            
            return default;
        }

        private static (bool hero, bool boss) Fight()
        {
            bool hero;
            bool boss;
            var HeroAttack = Hero.Attack();
            var BossAttack = Boss.Attack(); //true, 31

            if (HeroAttack == -1)
            {
                hero = false;
            }
            else
            {
                hero = true;
                Boss.TakeDamage(HeroAttack);
            }

            if (BossAttack == -1)
            {
                boss = false;
            }
            else
            {
                boss = true;
                Hero.TakeDamage(BossAttack);
            }
            return (hero, boss);
        }

        private static void ItterationResult(bool hero, bool boss)
        {
            if (hero) Console.WriteLine($"the Hero attacked and did {Hero.Damage()} Damage!\n");
            else Console.WriteLine("the Hero decided to recharge his stamina");

            if (boss) Console.WriteLine($"Boss: attacked and did {Boss.Damage()} Damage!\n");
            else Console.WriteLine("the Boss decided to recharge his stamina");
            
        }
    }
}
//Dere skal lage en konsoll app som viser en battle mellom en hero og en boss.

//Skriv en klasse GameCharacter som har en metode Fight(), en metode Recharge() og følgende properties:

//Health, Strength, Stamina

//Program.cs filen må initialisere to objekter av denne klassen, en Hero og en Boss med følgende stats:

//Hero:                      Boss:         
//Health: 100                Health: 400
//Strength: 20               Strength: 0 - 30
//Stamina: 40                Stamina: 10

//Disse to skal i kamp frem til en seirer (motstanderen sin health = 0) konsollen skal logge hvem som angriper,
//hvor mye skade som tas og hvor mye liv motstanderen har igjen etter slaget.

//I en fight mister GameCharacterene like mye i Health som mostanderen har i Strength.

//Hver gang en character bruker metoden Fight() mister de også 10 stamina.

//Om Fight() kalles med 0 i stamina må de bruke metoden Recharge() som restorer Stamina til det de hadde da de startet kampen.
//De rundene gamecharacterene må recharge får de ikke utført noe skade.

//Styrken til Bossen varierer med en random verdi mellom 0-30 for hver gang Fight() kalles. Om dette blir for avansert, la bossen også få en fast styrke på 20.