using static Emne3.Pokemon_game.pokemon_methods;
namespace Emne3.Pokemon_game
{
    internal class Pokemon_Combat
    {
        internal static void runcombat(Pokemon[]? enemyTeam, Pokemon[]? solidTeam)
        {
            Console.Clear();
            Console.SetCursorPosition(0, 3);
            ShowTeams(enemyTeam, solidTeam);

            Console.WriteLine("this project needed to stop, in favor of furthering my education");
            Console.ReadLine();
        }
    }
}
