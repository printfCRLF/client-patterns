using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using DmitriNesteruk.Common;
using DmitriNesteruk.Common.Logging;

namespace DmitriNesteruk.s02
{
    class m10_RegisteringInstances
    {
	    public void Run()
	    {
		    var builder = new ContainerBuilder();
		    
			var log = new ConsoleLog();
		    builder.RegisterInstance(log).As<ILog>();

		    builder.RegisterType<Car>()
			    .UsingConstructor(typeof(Engine));
		    builder.RegisterType<Engine>();

		    var container = builder.Build();
		    var car = container.Resolve<Car>();
		    car.Go();
	    }
    }
}
