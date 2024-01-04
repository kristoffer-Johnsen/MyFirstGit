using static Emne3.Pokemon_game.pokemon_methods;

namespace Emne3.Pokemon_game
{
    internal class GetPokemon
    {
        public static void Run()
        {
            //----------------------------team construction----------------------------------//

            Console.Clear();
            var team = new List<Pokemon>();

            Console.SetCursorPosition(0, 3);
            Console.WriteLine("you will be asked to name 6 pokemon, these will be added to your team");

            ConstructTeam(team);

            Pokemon[]? solidTeam = team.ToArray();


            //------------------------stat inspection and changing---------------------------//

            Console.WriteLine("would you like to see you team stats? Y/N");
            if (Console.ReadLine()?.ToLower() == "y")
            {
                Console.Clear();
                Console.SetCursorPosition(0, 3);
                Console.WriteLine("This is your Team:");

                foreach (var member in solidTeam)
                {
                    ShowPokemonDetails(member);
                }

                Console.WriteLine("would you like to change some stats? Y/N");
                if (Console.ReadLine()?.ToLower() == "y")
                {
                    Console.Clear();
                    EditPokemon(solidTeam);
                }

            }

            //---------------------restart from scratch or continue prompt-------------------//
            
            Console.Clear();
            Console.SetCursorPosition(0, 3);
            Console.WriteLine("would you like to Restart? or continue to fight a another trainer? restart/continue");

            //--------------------- enemy team creation -------------------------------------//

            if (Console.ReadLine()?.ToLower() == "continue")
            {
                team.Clear();
                var fullTeam = false;
                while (!fullTeam)
                {
                    var name = Namelist();
                    var teamMember = new Pokemon(name, 1);
                    team.Add(teamMember);

                    if (team.Count == 6)
                    {
                        fullTeam = true;
                    }
                }

                var enemyTeam = team.ToArray();

                //-------------------------- combat starts (its own class)-----------------------//

                Pokemon_Combat.runcombat(enemyTeam, solidTeam);
            }

            //-----------------------------Clear and restart---------------------------------//

            else
            {
                Console.Clear();
                team.Clear();
                Run();
            }

            //-------------------------------------------------------------------------------//
        }
    }
}