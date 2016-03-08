using System;
using Blobs.Interfaces;

namespace Blobs.IO
{
    public class ConsoleWriteLine : IOutputWriter
    {
        public void PrintLine(string line)
        {
            Console.WriteLine(line);
        }
    }
}
