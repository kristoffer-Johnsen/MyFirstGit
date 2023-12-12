
namespace LearningObjectOrienting
{
    internal class run
    {
        public static void program()
        { 
        /*javascript way:
        let pikachu = { Health : 50, Level : 25 };
        */
        /*C# way closest to JS*/
        var pikachu = new { Health = 50, Level = 25 };
        Console.WriteLine($"Pikachu is level {pikachu.Level} and has {pikachu.Health} HP");

        /*C# conventional and recommended way*/
        var squirtle = new pokemon()
        {
            Health = 100
        };

        squirtle.show("squirtle");
        }

    }

    public class pokemon
    {
        public int Health = 50;
        public int Level = 25;
        public void show(string parameter)
        {
            Console.WriteLine($"{parameter} is level {Level} and has {Health} HP");
        }
    }

}
