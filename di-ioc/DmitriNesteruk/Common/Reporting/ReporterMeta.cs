using System;
using System.Collections.Generic;
using System.Text;
using Autofac.Features.Metadata;
using DmitriNesteruk.Common.Logging;

namespace DmitriNesteruk.Common.Reporting
{
	public class Settings
	{
		public string LogMode { get; set; }
	}

	public class ReporterMeta
	{
		private Meta<ConsoleLog, Settings> log;

		public ReporterMeta(Meta<ConsoleLog, Settings> log)
		{
			this.log = log;
		}

		public void Report()
		{
			log.Value.Write("Starting report");
			if (log.Metadata.LogMode == "verbose")
			{
				log.Value.Write($"VERBOSE MODE: logger started on {DateTime.Now}");
			}
			//if (log.Metadata["mode"] as string == "verbose")
			//{
			//	log.Value.Write($"VERBOSE MODE: logger started on {DateTime.Now}");
			//}
		}
	}
}
