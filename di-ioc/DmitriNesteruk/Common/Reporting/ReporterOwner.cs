using System;
using System.Collections.Generic;
using System.Text;
using Autofac.Features.OwnedInstances;
using DmitriNesteruk.Common.Logging;

namespace DmitriNesteruk.Common.Reporting
{
	class ReporterOwner
	{
		private Owned<ConsoleLog> log;

		public ReporterOwner(Owned<ConsoleLog> log)
		{
			this.log = log ?? throw new ArgumentNullException(paramName: nameof(log));
			Console.WriteLine("Reporting initialized");
		}

		public void ReportOnce()
		{
			log.Value.Write("Log started");
			log.Dispose();
		}
	}
}
