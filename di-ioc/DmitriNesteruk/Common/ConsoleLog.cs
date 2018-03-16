using System;

namespace DmitriNesteruk.Common
{
    public class ConsoleLog : ILog, IConsole
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}