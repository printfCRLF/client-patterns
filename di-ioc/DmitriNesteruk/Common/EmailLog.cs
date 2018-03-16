using System;
using System.Collections.Generic;
using System.Text;

namespace DmitriNesteruk.Common
{
	class EmailLog : ILog, IConsole
	{
		private const string adminEmail = "admin@foo.com";

		public void Write(string message)
		{
			Console.WriteLine($"Email sent to {adminEmail} : {message}");
		}
	}
}
