using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using DmitriNesteruk.Common;
using DmitriNesteruk.Common.Logging;
using DmitriNesteruk.Common.Reporting;

namespace DmitriNesteruk.s04
{
    class m21_DelayedInstantiation
    {
	    public void Run()
	    {
		    var builder = new ContainerBuilder();
		    builder.RegisterType<ConsoleLog>();
		    builder.RegisterType<Reporter>();

		    using (var c = builder.Build())
		    {
			    c.Resolve<Reporter>().Report();
		    }
	    }
    }
}
