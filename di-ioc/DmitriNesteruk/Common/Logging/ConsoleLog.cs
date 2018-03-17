using System;

namespace DmitriNesteruk.Common.Logging
{
	public class ConsoleLog : ILog, IConsole
	{
		public ConsoleLog()
		{
			Console.WriteLine($"Console log created at {DateTime.Now.Ticks}");	
		}

		public void Write(string message)
		{
			Console.WriteLine(message);
		}

		public void Dispose()
		{
			Console.WriteLine("Console logger no longer required");
		}
	}
}