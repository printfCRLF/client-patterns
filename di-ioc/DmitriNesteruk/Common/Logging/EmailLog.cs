using System;

namespace DmitriNesteruk.Common.Logging
{
	class EmailLog : ILog, IConsole
	{
		private const string adminEmail = "admin@foo.com";

		public void Write(string message)
		{
			Console.WriteLine($"Email sent to {adminEmail} : {message}");
		}

		public void Dispose()
		{
			Console.WriteLine("Email logger no longer required");
		}
	}
}
