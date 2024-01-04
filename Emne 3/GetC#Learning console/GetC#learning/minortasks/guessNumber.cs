namespace GuessNumber
{
    public class GetNumber
    {

        public static void NumberGuesser()
        {
            Console.WriteLine("guess my number 1-10");

            int secretNumber = GetRandomNumber(1, 10);

            var answer = Convert.ToInt16(Console.ReadLine());

            CheckAnswer(secretNumber, answer);

        }

        public static int GetRandomNumber(int min, int max)
        {
            return new Random().Next(min, max);
        }

        public static void CheckAnswer(int secretNumber, short answer)
        {
            if (answer > secretNumber)
            {
                Console.WriteLine("The Number is lower");
            }

            else if (answer < secretNumber)
            {
                Console.WriteLine("The number is higher");
            }

            else if (answer == secretNumber)
            {
                Console.WriteLine("you Are correct");

                Console.WriteLine("would you like go again? Y/N");
                string startover = Console.ReadLine()!;

                if (startover.ToLower() == "y")
                {
                    GetRandomNumber(1, 10);
                    Console.WriteLine("new number chosen");
                }
                else
                {
                    return;
                }
            }
            answer = Convert.ToInt16(Console.ReadLine());
            CheckAnswer(secretNumber, answer);
        }


    }
}
