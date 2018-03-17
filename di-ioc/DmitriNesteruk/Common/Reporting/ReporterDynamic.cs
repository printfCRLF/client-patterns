using System;
using System.Collections.Generic;
using System.Text;
using DmitriNesteruk.Common.Logging;

namespace DmitriNesteruk.Common.Reporting
{
	class ReporterDynamic
	{
		private Func<ConsoleLog> consoleLog;

		public ReporterDynamic(Func<ConsoleLog> consoleLog)
		{
			this.consoleLog = consoleLog ?? throw new ArgumentNullException(paramName: nameof(consoleLog));

		}

		public void Report()
		{
			consoleLog().Write("Reporting to console");
			consoleLog().Write("and again");
		}
	}
}
