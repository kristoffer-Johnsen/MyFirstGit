
namespace Emne3.Organtransplant
{
    internal class human
    {
        private string _name { get; }
        private int _age { get; set; }
        private int _kidney { get; set; }

        private int _Compatability;

        public human(string Name, int Comp = -1)
        {
            _name = Name;
            _age = 0;
            _kidney = 2;
            _Compatability = (Comp == -1) ? Compatability() : Comp;
        }

        internal string Name()
        {
            return _name;
        }

        internal int Age()
        {
            return _age;
        }

        internal int KidneyStatus()
        {
            return _kidney;
        }

        public void LoseKidney()
        {
            _kidney--;
        }

        internal static void TransferKidney(human human1,human human2)
        {
            human1._kidney--;
            human2._kidney++;
        }
        private int Compatability()
        {
            Random rnd = new();
            if (rnd.Next(0, 2) == 0) return 1;
            return 0;
        }

        public static void Compatabilitycheck(human human1, human human2)
        {
            
            var result = human1._Compatability == human2._Compatability ? "positive":"negative";

            Console.WriteLine($"compatability test\n\n" +
                              $"  {human1._name} and {human2._name}\n" +
                              $"    {result}\n");
        }
    }
}