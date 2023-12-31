﻿

using Emne3.Klikkespill.CommandFolder;

namespace Emne3.Klikkespill
{
    //heavily helped by the solution suggestion, didnt realy understand what the task was asking of me
    internal class Clicker
    {
        public static void Start()
        {
            var game = new ClickerGame();
            var commands = new Commands(game);
            while (true)
            {
                Console.Clear();
                Console.WriteLine(
                    "Kommandoer:\r\n" +
                    " - SPACE = klikk (og få poeng)\r\n" +
                    " - K = kjøp oppgradering \r\n" +
                    "       øker poeng per klikk \r\n" +
                    "       koster 10 poeng\r\n" +
                    " - S = kjøp superoppgradering \r\n" +
                    "       øker \"poeng per klikk\" for den vanlige oppgraderingen.\r\n" +
                    "       koster 100 poeng\r\n" +
                    " - X = avslutt applikasjonen");

                Console.WriteLine($"Du har {game.Points} poeng.");
                Console.WriteLine("Trykk tast for ønsket kommando.");
                var command = Console.ReadKey().KeyChar;
                commands.Run(command);
            }
        }
    }
}