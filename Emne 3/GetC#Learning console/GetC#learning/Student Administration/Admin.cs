namespace Emne3.Student_Administration
{
    internal class Admin
    {
        internal static void Start() //Main
        {
            var studenter = GenererStudenter(3);
            PrintStudentInfo(studenter);
        }

        private static void PrintStudentInfo(List<Student> studenter)
        {
            foreach (var student in studenter)
            {
                Console.WriteLine("=== STUDENT INFO ===");
                student.SkrivUtInfo();
                Console.WriteLine("\n=== FAG INFO ===");
                foreach (var fag in student.Studieprogram)
                {
                    fag.SkrivUtInfo();
                    Karakter fagnavn = new Karakter();
                    fagnavn.SkrivUtInfo();
                }

            }
        }

        private static List<Student> GenererStudenter(int antallStudenter)
        {
            List<Student> studenter = new();
            Random rnd = new();

            string[] names =
            {
                "Lars", "Mette", "Ole", "Ingrid", "Per",
                "Hilde", "Andreas", "Sofie", "Erik", "Kristin",
                "Trond", "Camilla", "Petter", "Marit", "Jon",
                "Elisabeth", "Kjell", "Lise", "Bjørn", "Anita"
            };
            int[] ages = new int[20];
            for (int i = 0; i < ages.Length; i++)
            {
                ages[i] = 18 + i;
            }

            for (int i = 0; i < antallStudenter; i++)
            {
                var random1 = rnd.Next(names.Length);
                var random2 = rnd.Next(ages.Length);
                var studieProgram = GenererStudieProgram();
                var student = new Student(names[random1], Guid.NewGuid(), ages[random2], studieProgram);
                studenter.Add(student);
            }

            return studenter;
        }

        private static List<Fag> GenererStudieProgram()
        {
            Random rnd = new();
            var fagnavn = Enum.GetNames(typeof(Fagnavn)).ToList(); // ¯\_(ツ)_/¯
            List<Fag> studieProgram = new();
            List<int> previouslySelectedIndices = new();

            for (int i = 0; i < 4; i++)
            {
                var index = rnd.Next(fagnavn.Count);
                while (previouslySelectedIndices.Contains(index))
                {
                    index = rnd.Next(fagnavn.Count);
                }

                var fag = new Fag((Fagnavn)index, 420); //TODO: Lag studiepoeng på en annen måte
                studieProgram.Add(fag);
                previouslySelectedIndices.Add(index);
            }

            return studieProgram;
        }
    }
}
