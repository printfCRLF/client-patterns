using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using DmitriNesteruk.Common.Logging;
using DmitriNesteruk.Common.Reporting;

namespace DmitriNesteruk.s04
{
    class m22_ControlledInstantiation
    {
	    public void Run()
	    {
		    var builder = new ContainerBuilder();
		    builder.RegisterType<ConsoleLog>();
		    builder.RegisterType<ReporterOwner>();

		    using (var c = builder.Build())
		    {
			    c.Resolve<ReporterOwner>().ReportOnce();
				Console.WriteLine("Done reporting");
		    }
	    }
    }
}
