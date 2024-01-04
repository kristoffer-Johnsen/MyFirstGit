using System.ComponentModel;
using Lagerstyringssytem.Products;

namespace Lagerstyringssytem
{
    //Del 4: Hovedprogram(Main)
    //I hovedprogrammet, gjør følgende: 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.SetCursorPosition(0, 3);

            //Opprett en instans av Lager.
            Storage storage = new();

            //Opprett minst to instanser av hver produkttype(Elektronikk, Matvare, Klær)
            //og legg dem til i lageret.

            clothes shirt = new("large", "Summershirt", 12);
            clothes shorts = new("large", "breezy", 20);

            food bread = new(1,"Bread", 3);
            food milk = new(1, "Milk", 2);

            electronic TV = new(1.5, "TV", 50);
            electronic Iphone = new(1.0, "Iphone", 1000);

            storage.add(shirt);
            storage.add(shorts);
            storage.add(bread);
            storage.add(milk);
            storage.add(TV);
            storage.add(Iphone);

            storage.show();
            Console.WriteLine("\n\nto continue press any button");
            Console.ReadKey();

            //Fjern et produkt fra lageret.
            storage.remove(Iphone);

            //List opp alle gjenværende produkter i lageret.
            Console.Clear();
            Console.SetCursorPosition(0, 3);
            storage.show();
            Console.WriteLine("\n\nto continue press any button");
            Console.ReadKey();
        }
    }
}


/*
 Del 1: Interface
   
   
   *Lag et grensesnitt kalt IProdukt med følgende medlemmer:
   
   *public interface IProdukt
   *{
   *string Navn { get; set; }
   *double Pris { get; set; } 
   *void SkrivUtInfo();
   *}

   *Del 2: Klasser
   *Implementer tre klasser som implementerer IProdukt-grensesnittet:

   *Elektronikk: 
   *Egenskap: Garantitid (i måneder).  

   *Matvare: 
   *Egenskap: Utløpsdato. 

   *Klær: 
   *Egenskap: Størrelse.
   

   *Del 3: Lagerstyringssystem  
   *Lag en klasse Lager som inneholder en liste av IProdukt. Implementer følgende funksjonalitet: 
   *Metode for å legge til et produkt i lageret.
   *Metode for å fjerne et produkt fra lageret.
   *Metode for å liste opp alle produkter i lageret.
   
   
   Del 4: Hovedprogram (Main)
   I hovedprogrammet, gjør følgende: 
   Opprett en instans av Lager.
   Opprett minst to instanser av hver produkttype (Elektronikk, Matvare, Klær) og legg dem til i lageret.
   Fjern et produkt fra lageret.
   List opp alle gjenværende produkter i lageret.
 */
