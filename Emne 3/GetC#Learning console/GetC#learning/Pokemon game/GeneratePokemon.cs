namespace Emne3.Pokemon_game
{

    internal class Pokemon
    {
        public static Random Rand = new Random();
        internal string? Name;
        internal int Level;
        internal int Health;
        internal int Attack;
        internal int Defence;

        public Pokemon(string? givenName, int level)
        {
            Name = givenName;
            Level = level;
            Health = Rand.Next(30, 100);
            Attack = Rand.Next(15, 45);
            Defence = Rand.Next(10, 30);
        }
    }
}




