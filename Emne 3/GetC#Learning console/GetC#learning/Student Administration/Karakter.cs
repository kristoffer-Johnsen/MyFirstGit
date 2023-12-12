namespace Emne3.Student_Administration
{
    internal class Karakter : IKarakter
    {


        public int _karakter { get; set; }
        
        public Karakter()
        {
            _karakter = HentKarakter();
        }

        private int HentKarakter()
        {
            Random rand = new Random();
            return rand.Next(1, 7);
        }

        public void SkrivUtInfo()
        { 
            Console.WriteLine($"karakter:  {_karakter}\n");
        }
    }
    
    internal interface IKarakter
    {
        public int _karakter { get; set; }
    }
}
//     Egenskaper: Student(referanse til en Student), Fag(referanse til et Fag), Karakterverdi.
//          Metode: SkrivUtInfo() som skriver ut informasjon om karakteren.