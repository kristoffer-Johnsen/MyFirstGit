
namespace Emne3.Organtransplant
{
    internal class organTransplant
    {
        internal static void start()
        {
            Console.Clear();
            Console.SetCursorPosition(0,3);
            human bernt = new("Bernt",1);
            Console.WriteLine("Bernt has been in a car accident, and as a result lost his kidney\n");
            //-------------Car accident---------------------------------//

            while (bernt.KidneyStatus() > 0)
            {
                bernt.LoseKidney();
            }

            //----------------------break-------------------------------//

            Console.ReadLine();
            Console.Clear();
            Console.SetCursorPosition(0, 3);
            
            //-------------compatability check oliver-------------------//

            human oliver = new("Oliver",0);
           
            human.Compatabilitycheck(bernt, oliver);

            Console.WriteLine($"his friend {oliver.Name()} got checked for compatability \n" +
                              "for a kidney transfer but unfortunately he was not a good match for Bernt");

            //----------------------break-------------------------------//

            Console.ReadLine();
            Console.Clear();
            Console.SetCursorPosition(0, 3);

            //-------------compatability check kåre---------------------//

            human kåre = new("Kåre",1);

            human.Compatabilitycheck(bernt , kåre);

            Console.WriteLine($"his cousin,{kåre.Name()},  has 2 kidneys and tests indicate\n" +
                              "that his kidneys will have a high chance of not getting rejected");

            //----------------------break-------------------------------//

            Console.ReadLine();
            Console.Clear();
            Console.SetCursorPosition(0, 3);

            //-------------------kidney transfer------------------------//

            Console.WriteLine($"before the transfer {kåre.Name()} had {kåre.KidneyStatus()} kidneys and \n" +
                              $"{bernt.Name()} had {bernt.KidneyStatus()} kidneys\n\n");

            human.TransferKidney(kåre, bernt);

            Console.WriteLine($"after the transfer {kåre.Name()} had {kåre.KidneyStatus()} kidney, and \n" +
                              $"{bernt.Name()} had {bernt.KidneyStatus()} kidney ");

            //-------------------------break----------------------------//

            Console.ReadLine();
            Console.Clear();
            Console.SetCursorPosition(0, 3);
        }

    }
}


// Oppgave: Organ transplant!
// Det har vært en akutt ulykke og Bernt ligger på sykehuset.
// 
// Han trenger en ny Nyre!
// 
// Heldigvis har fetteren hans Kåre to sunne Nyrer, og det er utført tester som tilsier at Kåre kan gi bort en av nyrene til Bernt og det vil være en høy suksessrate for overlevelse!
// 
// Hjelp Bernt med å overleve!
// 
// Finn ut hva vi kan lage som objekter, og hva man kan lage som metoder i dette tilfellet.
// 
// Lag gjerne Consoll.WriteLine() - statements i koden slik at man ser hva som skjer!