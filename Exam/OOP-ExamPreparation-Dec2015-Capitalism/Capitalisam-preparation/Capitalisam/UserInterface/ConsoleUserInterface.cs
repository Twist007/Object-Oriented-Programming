using System;
using Capitalisam.Interfaces;

namespace Capitalisam.UserInterface
{
    public class ConsoleUserInterface : IUserInterface
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void Write(string output)
        {
            Console.WriteLine();
        }

        public void WriteLine(string format, params object[] args)
        {
            Console.WriteLine(format,args);
        }
    }
}
