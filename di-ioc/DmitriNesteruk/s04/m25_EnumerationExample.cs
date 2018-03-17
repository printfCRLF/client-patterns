using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using DmitriNesteruk.Common.Logging;
using DmitriNesteruk.Common.Reporting;

namespace DmitriNesteruk.s04
{
    class m25_EnumerationExample
    {
	    public void Run()
	    {
		    var builder = new ContainerBuilder();
		    builder.RegisterType<ConsoleLog>().As<ILog>();
		    builder.Register(c => new SmsLog("+460760362953")).As<ILog>();
			builder.RegisterType<EmailLog>().As<ILog>();
			builder.RegisterType<Reporters>();

		    using (var c = builder.Build())
		    {
			    c.Resolve<Reporters>().Report();
			    //Console.WriteLine("Done reporting");
		    }
	    }
	}
}
