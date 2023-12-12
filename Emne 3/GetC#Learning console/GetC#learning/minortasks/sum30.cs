
namespace Sum30;

internal class CheckIf30
{
    public static bool NumberCheck()
    {
        int number1 = Convert.ToInt32(Console.ReadLine());
        int number2 = Convert.ToInt32(Console.ReadLine());

        bool answer;
        if (number1+number2 == 30)
        {
            answer = true;
        }
        else
        {
            answer = false;
          
        }
        return answer;
    }
}