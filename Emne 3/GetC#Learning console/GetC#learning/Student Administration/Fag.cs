namespace Emne3.Student_Administration
{
    internal class Fag
    {
        public Fagnavn Navn { get; set; }
        public int Fagkode{ get;}
        public int AntallStudiepoeng { get;}

        public Fag(Fagnavn navn, int antallStudiepoeng)
        {
            Navn = navn;
            Fagkode = Convert.ToInt32(navn);
            AntallStudiepoeng = antallStudiepoeng;
        }

        public void SkrivUtInfo()
        {
            Console.WriteLine($"Navn:        {Navn}\n" +
                              $"Fagkode:     {Fagkode}\n" +
                              $"Studiepoeng: {AntallStudiepoeng}\n");
        }
    }

    public enum Fagnavn
    {
        English,
        Norsk,
        Samfunnsfag,
        Matte,
        Programmering,
        Fysikk,
        Trigonometri
    }
}