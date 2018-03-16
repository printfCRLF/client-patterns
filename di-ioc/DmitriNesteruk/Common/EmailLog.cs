using System;
using System.Collections.Generic;
using System.Text;

namespace DmitriNesteruk.Common
{
	class EmailLog : ILog
	{
		private const string adminEmail = "admin@foo.com";

		public void Write(string message)
		{
			Console.WriteLine($"Email sent to {adminEmail} : {message}");
		}
	}
}
