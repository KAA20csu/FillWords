using System;
using Tabl;
using Dummy;
using NewGame;


namespace Selecting
{
    class Select
    {
        static void Main(string[] args)
        {
            Menu i = new Menu();
            i.MenuInfo();
            ConsoleKeyInfo hkey;
            int Y = 0;
            do
            {
                Console.SetCursorPosition(0, Y);
                hkey = Console.ReadKey();
                if (hkey.Key == ConsoleKey.UpArrow || hkey.Key == ConsoleKey.W) Y--;
                if (hkey.Key == ConsoleKey.DownArrow || hkey.Key == ConsoleKey.S) Y++;

                if (Y < 0) Y = 3;
                if (Y > 3) Y = 0;

                if (Y == 0) SelectedNewGame();
                if (Y == 1) SelectedContinue();
                if (Y == 2) SelectedRating();
                if (Y == 3) SelectedExit();
                if(hkey.Key == ConsoleKey.Enter)
                {
                    SelectStep(Y);

                    if (Y == 0)
                        break;
                }

            }
            while (hkey.Key != ConsoleKey.Escape);

        }
        private static void SelectedNewGame()
        {
            Console.Clear();

            Menu i = new Menu();
            i.Head();
            Console.ForegroundColor = ConsoleColor.White;
            i.NewGame();
            Console.ForegroundColor = ConsoleColor.Green;
            i.Continue();
            i.Rating();
            i.Exit();
        }
        private static void SelectedContinue()
        {
            Console.Clear();
            Menu i = new Menu();
            i.Head();
            i.NewGame();
            Console.ForegroundColor = ConsoleColor.White;
            i.Continue();
            Console.ForegroundColor = ConsoleColor.Green;
            i.Rating();
            i.Exit();
        }
        private static void SelectedRating()
        {
            Console.Clear();
            Menu i = new Menu();
            i.Head();
            i.NewGame();
            i.Continue();
            Console.ForegroundColor = ConsoleColor.White;
            i.Rating();
            Console.ForegroundColor = ConsoleColor.Green;
            i.Exit();

        }
        private static void SelectedExit()
        {
            Console.Clear();
            Menu i = new Menu();
            i.Head();
            i.NewGame();
            i.Continue();
            i.Rating();
            Console.ForegroundColor = ConsoleColor.White;
            i.Exit();
            Console.ForegroundColor = ConsoleColor.Green;
        }
        private static void SelectStep(int Y)
        {
            DummyCl i = new DummyCl();
            Newestgame e = new Newestgame();
            if (Y == 0) { e.NewGamee();}
            if (Y == 1) { i.Continue();}
            if (Y == 2) { i.Rating();}
            if (Y == 3) { i.Exit();}
        }
    }
}
