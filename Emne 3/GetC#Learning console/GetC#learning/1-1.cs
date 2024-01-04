

namespace Emne3
{
    internal class GradeProgram
    {
        internal static void Start()
        {
            IGradeable student1 = new Student
            {
                StudentName = "John Doe",
                StudentId = 0
            };

            Console.WriteLine($"Student Name: {student1.StudentName}");
            Console.WriteLine($"Student ID: {student1.StudentId}");
            Console.WriteLine($"Overall Grade: {student1.CalculateGrade()}\n\n");
        }
    }

    internal partial class Student : IGradeable
    {
        public string? StudentName { get;  set; }
        public int StudentId { get; set; }

        public double CalculateGrade()
        {
            Random rnd = new();
            return rnd.Next(60, 100);
        }
    }

    internal partial class Student : Isomething
    {
        public string? Name1 { get; set; }
    }

    public interface Isomething
    { 
        string? Name1 {get; set;}
    }

    public interface IGradeable
    {
        double CalculateGrade();
        string? StudentName { get; set; }
        int StudentId { get; set; } 
    }

    public enum Grade
    {
        A,
        B,
        C,
        D,
        E,
        F
    }
}