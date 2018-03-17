using System;
using System.Collections.Generic;
using System.Text;
using Autofac.Features.Indexed;
using DmitriNesteruk.Common.Logging;

namespace DmitriNesteruk.Common.Reporting
{
	class ReporterIndex
	{
		private IIndex<string, ILog> loggers;

		public ReporterIndex(IIndex<string, ILog> loggers)
		{
			this.loggers = loggers;
		}

		public void Report()
		{
			loggers["sms"].Write("Starting report output");
		}
	}
}
