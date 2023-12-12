// See https://aka.ms/new-console-template for more information

namespace PP_Kristoffer____Simon
{
    public class Program
    {
        public static List<Hobbier> Hobbier;

        public static void Main(string[] args) 
        {
            string options = string.Empty;
            while(options != "0")
            {
                options = menu();
                switch(options)
                {
                    case "0":
                        break;
                    
                    case "1":
                        partOne(); 
                        break;

                    case "2":
                        partTwo();
                        break;
                }
                Console.WriteLine($"Press <Enter> To Continue");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                Console.Clear();
            }
        }
        public static void partOne()
        {
            User simon = new ("Simon", "brown", 21);
            simon.PrintInfo();
            //----------------------------------------------------//
            Console.WriteLine($"Press <Enter> To Continue");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Console.Clear();
            //-----------------------------------------------------//
            User kristoffer = new("kristoffer", "blonde", 33);
            kristoffer.PrintInfo();
        }
        
        public static void partTwo() 
        {
            User simon = new("Simon", "brown", 21);
            User kristoffer = new("kristoffer", "blonde", 33);
            
            Hobbier gaming = new ("Gaming", "hvor man spiller spill");
            Hobbier anime = new ("Anime", "Ser på japansk animasjons film");
            simon.Hobbies.Add(gaming);
            simon.PrintHobbiesInfo();
            kristoffer.Hobbies.Add(anime);
            kristoffer.PrintHobbiesInfo();

        }

        public static string menu()
        {
            Console.Clear();
            Console.WriteLine("|---------------------------|");
            Console.WriteLine("|-           PP            -|");
            Console.WriteLine("|---------------------------|");
            Console.WriteLine("|- 1. Part one");
            Console.WriteLine("|- 2. Part two");
            Console.WriteLine("|- 0. Exit");
            Console.WriteLine("|- Choose");
            return Console.ReadLine();
        }
    }
}



/*
   Model yourself
   I denne oppgaven skal du prøve å programmere deg selv 🤓 
    Du har noen gitte egenskaper og ting du liker å gjøre. 
   Lag et hovedprogram der hver av deltakerene har sin klasse som kan printe
    ut en introduksjonstekst, og også utføre hver sine hobbyer.
*/