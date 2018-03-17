using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using DmitriNesteruk.Common.Logging;
using DmitriNesteruk.Common.Reporting;

namespace DmitriNesteruk.s04
{
    class m23_DynamicInstantiation
    {
	    public void Run()
	    {
		    var builder = new ContainerBuilder();
		    builder.RegisterType<ConsoleLog>();
		    builder.RegisterType<ReporterDynamic>();

		    using (var c = builder.Build())
		    {
			    c.Resolve<ReporterDynamic>().Report();
			    Console.WriteLine("Done reporting");
		    }
	    }
	}
}
