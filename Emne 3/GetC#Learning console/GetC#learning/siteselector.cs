using gamespace;
using findcodefunction;
using LearningObjectOrienting;
using Emne3;
using Emne3.FriendFace;
using Emne3.Pokemon_game;
using Emne3.Student_Administration;
using kodeSammenMedKristoffer;
using Terje;
using Emne3.Bossfight;
using Emne3.Klikkespill;
using static CompareTwo.Compare;
using static GuessNumber.GetNumber;
using static CombineNumbers.Combine;
using static Sum30.CheckIf30;
using static ForEachTask.RunTask;
using static WhileLoopTask.Loop;
using Emne3.Organtransplant;

//just pointing out that i know the namespace is a mess, and that its intentional, to learn more about namespaces--------//

namespace siteselector
{
    public class Sitelist
    {
        internal static void start()
        {
            var running = true;

            while (running)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 3);
                Console.WriteLine(" ------------------------------------------------------------------------ \n" +
                                  "|                  this is a set of school assignments                   |\n" +
                                  "|      some are not finished or had to be put aside for others           |\n" +
                                  "|                                                                        |\n" +
                                  "|                      what would you like to do?                        |\n" +
                                  "|                  here is a list of possible commands                   |\n" +
                                  "|                guessnumber, compare, combine, check30                  |\n" +
                                  "|                  forloop, foreach, while,crocodile                     |\n" +
                                  "|                  testcode, pokemon, demo, grade                        |\n" +
                                  "|                        admin, transplant,                              |\n" +
                                  " ------------------------------------------------------------------------ ");





                Console.WriteLine("         if you see this you can write 'done' to exit the console");

                string? whatToDo = null;
                while (string.IsNullOrEmpty(whatToDo)) whatToDo = Console.ReadLine();
                running = (whatToDo.ToLower() != "done");
                GoTo(whatToDo);
            
            }
        }

        //------ first switch will get better with time------//
        public static void GoTo(string? whatToDo)
        {
            switch (whatToDo!.ToLower())
            {
                case "guessnumber": NumberGuesser();
                    break;
                case "compare": TwoNumbers();
                    break;
                case "combine": Numbers();
                    break;
                case "check30": NumberCheck();
                    break;
                case "forloop": ErKul.checkcool();
                    break;
                case "foreach": LoopTask();
                    break;
                case "while": WhileTask();
                    break;
                case "crocodile": Crocodilegame.GameStart();
                    break;
                case "testcode": TestThisCode.testcode();
                    break;
                case "pikachu": run.program();
                    break;
                case "pokemon": GetPokemon.Run();
                    break;
                case "demo": Demo.program();
                    break;
                case "grade": GradeProgram.Start();
                    break;
                case "admin": Admin.Start();
                    break;
                case "transplant": organTransplant.start();
                    break;
                case "face": FriendFace.Start();
                    break;
                case "boss": BossFight.Start();
                    break;
                case "clickergame": Clicker.Start();
                    break;
                default: Console.WriteLine("not a valid input, try again.");
                    return;
            }
        }
    }
}

