

namespace kodeSammenMedKristoffer
{
    internal class Demo
    {
        internal static void program()
        {
            Console.Write("Skriv inn en settning:");
            string? settning = null;
            while (settning == null) settning = Console.ReadLine();
            // string settning = Console.ReadLine();

            Console.WriteLine("hva vil du gjøre? \n 1  =reverser \n 2 = lowercase \n 3 = Uppercase");
            var svar = Console.ReadLine();

            switch (svar)
            {
                case "1":
                    metode1(settning);
                    GjøreMer();
                    break;
                case "2":
                    metode2(settning);
                    GjøreMer();
                    break;
                case "3":
                    metode3(settning);
                    GjøreMer();
                    break;
                default:
                    break;
            }

            /*
                            String result = switch (value)
                            {
                                case 1-> "Something";
                                case 2-> "Something else";
                                case 3->

                            //  Add more cases as needed
                                default -> throw new IllegalArgumentException("Unexpected value: " + value);
                            };
            */


            //Chat gpt hjelp

            static char ToUppercase(char character)
            {
                // Check if the character is a lowercase letter
                if (character >= 'a' && character <= 'z')
                {
                    // Convert to uppercase by subtracting the ASCII offset
                    return (char)(character - ('a' - 'A'));

                    //hvis character = j og j = 106 (ASCII verdien)
                    //a = 97, A = 65
                    //97 - 65 = 32
                    //106 (j) - 32 (a - A) = 74
                    //ASCII 74 = J
                }

                // Return unchanged for non-lowercase letters
                return character;
            }

            static char ToLowercase(char character)
            {
                if (character >= 'A' && character <= 'Z')
                {
                    return (char)(character + ('a' - 'A'));
                }

                return character;
            }

            static void GjøreMer()

            {
                Console.WriteLine("vil du gjøre noe mer? y/n");

                char noeannet = Convert.ToChar(Console.ReadLine()!);
                char redigertsvar = ToLowercase(noeannet);
                if (redigertsvar == 'y')
                {
                    program();
                }
            }

            static void metode1(string? settning)
            {
                string revSettning = "";
                for (int i = settning!.Length - 1;
                     i >= 0;
                     --i)
                {
                    revSettning += settning[i];
                }

                Console.WriteLine("Reversert settning");
                Console.WriteLine(revSettning);
            }

            static void metode2(string? settning)
            {
                var LowerSettning = "";
                for (int i = 0;
                     i < settning!.Length;
                     i++)
                {
                    char bokstav = ToLowercase(settning[i]);

                    LowerSettning += bokstav;
                }

                Console.WriteLine(LowerSettning);
            }

            static void metode3(string? settning)
            {
                var UpperSettning = "";
                for (int i = 0;
                     i < settning!.Length;
                     i++)
                {
                    char bokstav = ToUppercase(settning[i]);

                    UpperSettning += bokstav;
                }

                Console.WriteLine(UpperSettning);
            }

        }

    }
}