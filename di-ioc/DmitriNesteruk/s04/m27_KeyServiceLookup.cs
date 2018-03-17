using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using DmitriNesteruk.Common.Logging;
using DmitriNesteruk.Common.Reporting;

namespace DmitriNesteruk.s04
{
    class m27_KeyServiceLookup
    {
	    public void Run()
	    {
		    var builder = new ContainerBuilder();
		    builder.RegisterType<ConsoleLog>().Keyed<ILog>("cmd");
		    builder.Register(c => new SmsLog("+123456789")).Keyed<ILog>("sms");
		    builder.RegisterType<ReporterIndex>();

		    using (var c = builder.Build())
		    {
			    c.Resolve<ReporterIndex>().Report();
		    }
		}
    }
}

