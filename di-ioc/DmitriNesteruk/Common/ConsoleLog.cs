using System;

namespace DmitriNesteruk.Common
{
    public class ConsoleLog : ILog
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}