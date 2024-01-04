
using static GuessNumber.GetNumber;

namespace gamespace
{
    internal class Crocodilegame
    {
        public static void GameStart()
        {
            bool gameon = true;
            int points = 0;
            while (gameon)
            {
                int number1 = GetRandomNumber(1,11);
                int number2 = GetRandomNumber(1,11);
            
                Console.WriteLine($"{number1}_{number2}");
                var answer= Console.ReadLine();
                if (number1 > number2 && answer == ">" || number1 < number2 && answer == "<" || number1 == number2 && answer== "=")
                {
                    points++;
                    Console.WriteLine("*Correct*");
                }
                else
                {
                    Console.WriteLine("sorry, wrong answer");
                    points--;
                }
                Console.WriteLine($"score:{points}");

                Console.WriteLine("would you like to go again? Y/N");
                string? ContinueCheck = Console.ReadLine();
                if (ContinueCheck!.ToLower() == "n")
                {
                    gameon=false;
                }
            }
        }
    }
}