using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using DmitriNesteruk.Common.Logging;
using DmitriNesteruk.Common.Reporting;

namespace DmitriNesteruk.s04
{
	class m26_MetadataInterrogation
	{
		public void Run()
		{
			var builder = new ContainerBuilder();
			//builder.RegisterType<ConsoleLog>().WithMetadata("mode", "verbose");
			builder.RegisterType<ConsoleLog>()
				.WithMetadata<Settings>(c => c.For(x => x.LogMode, "verbose"));
			builder.RegisterType<ReporterMeta>();

			using (var c = builder.Build())
			{
				c.Resolve<ReporterMeta>().Report();
			}
		}
	}
}
