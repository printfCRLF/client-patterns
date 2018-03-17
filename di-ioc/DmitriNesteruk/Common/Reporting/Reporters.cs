using System;
using System.Collections.Generic;
using System.Text;
using DmitriNesteruk.Common.Logging;

namespace DmitriNesteruk.Common.Reporting
{
	class Reporters
	{
		private IList<ILog> loggers;

		public Reporters(IList<ILog> loggers)
		{
			if (loggers != null)
			{
				this.loggers = loggers;
			}
		}

		public void Report()
		{
			foreach (var logger in loggers)
			{
				logger.Write($"Hello, this is {logger.GetType().Name}");
			}
		}
	}
}
