
namespace CompareTwo;

internal class Compare
{
    public static bool TwoNumbers()
    {
        Console.WriteLine("see if two numbers are the same");
        int number1 = Convert.ToInt16(Console.ReadLine());
        int number2 = Convert.ToInt16(Console.ReadLine());
        if (number1 == number2)
        {
            Console.WriteLine(true);
            return true;
        }
        else
        {
            Console.WriteLine(false);
            return false;
        }
    }
}