
namespace CombineNumbers
{
    internal class Combine
    {
        public static int Numbers()
        {
            Console.WriteLine("write two numbers.\n if the numbers are the same, they are multiplied\n if they are different, they will me added together.");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            if (number1==number2)
            {
                sum = number1 * number2;
            }
            else if (number1!=number2)
            {
                sum = number1 + number2;
            }
            Console.WriteLine(sum);
            return sum;
        }
    }
}