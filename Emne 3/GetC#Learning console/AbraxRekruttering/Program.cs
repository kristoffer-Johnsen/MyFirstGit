using System.Drawing;
using AbaxRekruttering.Vehicles;

namespace AbaxRekruttering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car Bil1 = new Car("NF123456", 147, 200, Color.Green);
            Car Bil2 = new Car("NF654321", 150, 195, Color.Blue);
        }
    }
}

/*
 * Skriv et konsoll-program i C# som kan:
 
    Printe informasjon om en en bil 1 med :
    reg. nr NF123456, 147kw effekt, maksfart 200km/t,
    grønn farge av typen lett kjøretøy.

    Printe informasjon om en annen bil (bil 2) med 
    reg. nr NF654321, 150kw effekt, maksfart 195km/t,
    blå farge og av typen lett kjøretøy

    Sammenlikne de to bilene over for å sjekke om de er det samme kjøretøyet 
   
    Printe informasjon om et fly med 
    kjennetegn LN1234, 1000kw effekt, 30m vingespenn,
    2tonn lasteevne, 10 tonn egenvekt I flyklasse jetfly

    Konsollprogrammet skal be flyet om å fly og printe dette i konsollet. 
    
    Konsollprogrammet skal be bil 1 om å kjøre og printe dette I konsollet     
    
    Printe informasjon om en båt med
    kjennetegn ABC123, 100kw effekt, maksfart på 30knop,
    500kg bruttotonnasje
*/