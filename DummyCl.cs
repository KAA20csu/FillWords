using System;

namespace Dummy
{
    public class DummyCl
    {
        public void Continue()
        {
            Console.Clear();
            Console.WriteLine("Скоро тут будет Continue...");
        }
        public void Rating()
        {
            Console.Clear();
            Console.WriteLine("Скоро тут будет Rating...");
        }
        public void Exit()
        {
            Console.Clear();
            Console.WriteLine("Bye-bye");
            Console.ReadKey();
            System.Environment.Exit(0);
        }
    }
}
