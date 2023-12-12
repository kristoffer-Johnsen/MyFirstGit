
namespace ForEachTask;

internal class RunTask
{
    public static void LoopTask()
    {
        string Sentence = "bokstaver i en string";
        Console.WriteLine("first foreach \n");
        foreach (char Letters in Sentence)
        {
            Console.Write(Letters);
        }

        Console.WriteLine("\n\nsecond foreach");

        string[] ArraySentence = new[] { "ord", "i", "et", "array" };

        foreach (string word in ArraySentence)
        {
            Console.WriteLine(word);
        }
    }
}