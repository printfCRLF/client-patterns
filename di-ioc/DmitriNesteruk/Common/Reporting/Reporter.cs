using System;
using DmitriNesteruk.Common.Logging;

namespace DmitriNesteruk.Common.Reporting
{
	class Reporter
	{
		private readonly Lazy<ConsoleLog> log;

		public Reporter(Lazy<ConsoleLog> log)
		{
			this.log = log ?? throw new ArgumentNullException(paramName: nameof(log));
			Console.WriteLine("Reporting component created");
		}

		public void Report()
		{
			log.Value.Write("Log started");
		}
	}
}
