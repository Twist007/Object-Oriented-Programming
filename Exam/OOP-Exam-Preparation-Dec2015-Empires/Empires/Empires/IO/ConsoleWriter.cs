using System;
using Empires.Charachters;

namespace Empires.IO
{
    public class ConsoleWriter : IOutputWriter
    {
        public void PrintLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
