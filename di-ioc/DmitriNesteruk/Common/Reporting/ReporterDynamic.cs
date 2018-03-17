using System;
using System.Collections.Generic;
using System.Text;
using DmitriNesteruk.Common.Logging;

namespace DmitriNesteruk.Common.Reporting
{
	class ReporterDynamic
	{
		private Func<ConsoleLog> consoleLog;

		private Func<string, SmsLog> smsLog;

		public ReporterDynamic(Func<ConsoleLog> consoleLog, Func<string, SmsLog> smsLog)
		{
			this.consoleLog = consoleLog ?? throw new ArgumentNullException(paramName: nameof(consoleLog));
			this.smsLog = smsLog;
		}

		public void Report()
		{
			consoleLog().Write("Reporting to console");
			consoleLog().Write("and again");

			smsLog("+460760362953").Write("Texting admins...");
		}
	}
}
