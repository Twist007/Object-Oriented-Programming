using System;
using Blobs.Interfaces;

namespace Blobs.IO
{
    public class ConsoleWriter : IOutputWriter
    {
        public void PrintLine(string line)
        {
            Console.Write(line);
        }
    }
}
