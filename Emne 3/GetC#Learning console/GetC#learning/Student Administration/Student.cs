namespace Emne3.Student_Administration
{
    internal class Student
    {
        internal string _navn;
        private readonly Guid _studentID;
        private int _alder;
        public List<Fag> Studieprogram;

        public Student(string navn, Guid studentId, int alder, List<Fag> studieprogram)
        {
            _navn = navn;
            _alder = alder;
            _studentID = studentId;
            Studieprogram = studieprogram;
        }

        public void SkrivUtInfo()
        {
            var studieprogram = string.Empty;

            foreach(var fag in Studieprogram) 
            {
                studieprogram += $"{fag.Navn}, ";
            }

            Console.WriteLine($"Navn:          {_navn}\n" +
                              $"Alder:         {_alder}\n" +
                              $"StudentID:     {_studentID}\n" +
                              $"Studieprogram: {studieprogram}\n");
        }
    }
}

// Egenskaper: Navn, Alder, Studieprogram, StudentID.
       // Metode: SkrivUtInfo() som skriver ut informasjon om studenten.