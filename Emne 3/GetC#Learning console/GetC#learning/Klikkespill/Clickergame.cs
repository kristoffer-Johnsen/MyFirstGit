
namespace Emne3.Klikkespill
{
    internal class ClickerGame
    {
        public int Points;
        int _pointsPerClick = 1;
        int _pointsPerClickIncrease = 1;

        internal void click()
        {
            Points += _pointsPerClick;
        }
        internal void upgrade()
        {
            if (Points >= 10)
            {
                Points -= 10;
                _pointsPerClick += _pointsPerClickIncrease;
            }
        }
        internal void SuperUpgrade()
        {
            if (Points >= 100)
            {
                Points -= 100;
                _pointsPerClickIncrease++;
            }
        }
    }
}
/*Oppgave

    Skriv om til mer objektorientert
   * ved å innføre en klasse ClickerGame
   * med objektvariabler for de tre int-variablene
    *og en metode for hver kommando.

    Innfør også et interface ICommand med kun én metode, Run.
    Lag så en klasse for hver kommando i applikasjonen.
    Lag også en egen klasse CommandSet.
    Denne har en array med et objekt av hver kommando.
    Når brukeren taster et tegn, skal dette sendes til metoden RunCommand i CommandSet.
    Der slår den opp hvilken kommando som har den aktuelle bokstaven
    og kjører så Run på denne kommandoen.*/