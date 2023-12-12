namespace Emne3.Pokemon_game
{
    internal class pokemon_methods
    {

        //--------------------team construction--------------//
        internal static void ConstructTeam(List<Pokemon> team)
        {
            var fullTeam = false;
            while (!fullTeam)
            {
                Console.WriteLine("\nname of pokemon?");
                string? name = Console.ReadLine();
                Console.WriteLine($"\n thank you {name} has been added to your team ");

                var teamMember = new Pokemon(name, 1);
                team.Add(teamMember);

                Console.Clear();
                Console.SetCursorPosition(0, 3);
                Console.WriteLine("Team:");
                ShowTeam(team);

                if (team.Count == 6)
                {
                    fullTeam = true;
                }
            }
        }
        //---------------prints out the team members name----------------------//
        internal static void ShowTeam(List<Pokemon> team)
        {
            foreach (var member in team)
            {
                Console.WriteLine(((Pokemon)member).Name);
            }
        }
        internal static void ShowTeams(Pokemon[]? enemyteam, Pokemon[]? team)
        {
            Console.WriteLine("enemy team:");
            foreach (var member in enemyteam!)
            {
                Console.WriteLine(member.Name);
            }
            Console.WriteLine("Your team:");
            foreach (var member in team!)
            {
                Console.WriteLine(member.Name);
            }
        }

        //---------------this just prints out the info about a pokemon---------//
        internal static void ShowPokemonDetails(Pokemon member)
        {
            Console.WriteLine($"\n  Name    :{member.Name}\n" +
                              $"    Level   :{member.Level}\n" +
                              $"    Health  :{member.Health}\n" +
                              $"    Attack  :{member.Attack}\n" +
                              $"    Defence :{member.Defence}\n");
        }

        //-----------------this is how pokemon gets chosen for edited----------//
        internal static void EditPokemon(Pokemon[]? solidTeam)
        {
            bool editingPokemon = true;

            while (editingPokemon)
            {

                Console.WriteLine("\nwhich pokemon would you like to change?");
                var chosenPokemon = Console.ReadLine();

                Console.WriteLine("\n what stat would you like to change?");
                string? chosenStat = Console.ReadLine();

                ShowSpecificStat(solidTeam, chosenPokemon, chosenStat);
                
                Console.WriteLine("\nwhat would you like it to be?");
                int statChange = Convert.ToInt16(Console.ReadLine());

                foreach (var member in solidTeam!)
                {
                    if (member.Name == chosenPokemon)
                    {
                        ChangeStat(chosenStat, member, statChange);
                        ShowPokemonDetails(member);
                    }
                }

                Console.WriteLine("do you want to do more changes? Y/N");

                if (Console.ReadLine()?.ToLower() == "n")
                {
                    editingPokemon = false;
                }
            }
        }
        //-------------------------shows one chosen stat-------------------------//
        private static void ShowSpecificStat(Pokemon[]? solidTeam, string? chosenPokemon, string? chosenStat)
        {
            foreach (var member in solidTeam!)
            {
                if (((Pokemon)member).Name == chosenPokemon)
                {
                    switch (chosenStat?.ToLower())
                    {
                        case "health":
                            Console.WriteLine($"\n{chosenPokemon}'s {chosenStat} stat is :{((Pokemon)member).Health}");
                            break;
                        case "attack":
                            Console.WriteLine($"{chosenPokemon}'s {chosenStat} stat is :{((Pokemon)member).Attack}");
                            break;
                        case "defence":
                            Console.WriteLine($"{chosenPokemon}'s {chosenStat} stat is :{((Pokemon)member).Defence}");
                            break;
                    }
                }
            }
        }

        //--------------this is how stats get changed in a pokemon----------------//
        internal static void ChangeStat(string? chosenStat, object member, int statChange)
        {
            switch (chosenStat?.ToLower())
            {
                case "health":
                    ((Pokemon)member).Health = statChange;
                    break;
                case "attack":
                    ((Pokemon)member).Attack = statChange;
                    break;
                case "defence":
                    ((Pokemon)member).Defence = statChange;
                    break;
                default:
                    Console.WriteLine("you are either not allowed to change this stat or it does not exist");
                    break;
            }
        }
        //--------------------------- namelist for enemy team--------------------------------------------//
        internal static string Namelist()
        { 
           int randomname = Pokemon.Rand.Next(0,10);

           List<string> names = new List<string>
           {
               "Alice",
               "Bob",
               "Charlie",
               "David",
               "Eva",
               "Frank",
               "Grace",
               "Henry",
               "Ivy",
               "Jack"
           };

            return names[randomname];
        }
    }
}
