
namespace findcodefunction
{
    internal class TestThisCode
    {
        public static void testcode()
        {

            var range = 250;
            var counts = new int[range];
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine()?.ToLower()!;
                foreach (var character in text ?? string.Empty)
                {
                    counts[(int)character]++;
                }
                for (var i = 0; i<range; i++)
                {
                    if (counts[i] > 0)
                    {
                        int percentage = 100 * counts[i] / text!.Length;

                        var character = (char)i;
                        Console.WriteLine(character + " - " + percentage + "%");
                    
                        string output = character + " - " + percentage.ToString("F2") + "%";
                        Console.CursorLeft = Console.BufferWidth - output.Length - 1;
                        Console.WriteLine(output);
                    }
                }
            }
        }

    }
}
/*  task 1: copy paste this task into visual studio
 * 
 *  task 2: find out what it does:
 *          this code counts letters in a submitted string
 *
 *  task 3: change code so that it isn't case sensitive.
 *      added ToLower() after readline
 *  
 *  task 4: change the count to percent.
 *      added  int percentage = 100 * counts[i] / text.Length;
 *  changed console.writeline(character + " - " + counts[i]")
 *  to      Console.WriteLine(character + " - " + percentage + "%");
 *
 *  task 5: make the numbers be right-justified
 *      i looked at the suggested solution and it gave me thi:
 *  string output = character + " - " + percentage.ToString("F2") + "%";
 *  Console.CursorLeft = Console.BufferWidth - output.Length - 1;
 *  Console.WriteLine(output);
 *
 *  keeping original to see difference
 */