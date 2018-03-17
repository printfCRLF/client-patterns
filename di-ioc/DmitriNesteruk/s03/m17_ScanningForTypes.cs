using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Autofac;
using DmitriNesteruk.Common;
using DmitriNesteruk.Common.Logging;

namespace DmitriNesteruk.s03
{
    class m17_ScanningForTypes
    {
	    public void Run()
	    {
		    var assembly = Assembly.GetExecutingAssembly();
		    var builder = new ContainerBuilder();

		    //builder.RegisterAssemblyTypes(assembly)
			   // .Where(t => t.Name.EndsWith("Log"))
			   // .Except<SmsLog>()
			   // .Except<ConsoleLog>(c => c.As<ILog>().SingleInstance())
			   // .AsSelf();

		    builder.RegisterAssemblyTypes(assembly)
			    .Except<SmsLog>()
			    .Where(t => t.Name.EndsWith("Log"))
			    .As(t => t.GetInterfaces()[0]);

		    var container = builder.Build();
		    var log = container.Resolve<ILog>();
			log.Write("Hello World");
	    }
    }
}
