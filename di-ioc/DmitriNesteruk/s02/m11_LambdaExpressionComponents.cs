using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using DmitriNesteruk.Common;
using DmitriNesteruk.Common.Logging;

namespace DmitriNesteruk.s02
{
    class m11_LambdaExpressionComponents
    {
	    public void Run()
	    {
		    var builder = new ContainerBuilder();
		    
		    var log = new ConsoleLog();
		    builder.RegisterInstance(log).As<ILog>();

		    builder.RegisterType<Car>();

		    builder.Register(c => 
			    new Engine(c.Resolve<ILog>(), 123));

		    var container = builder.Build();
		    var car = container.Resolve<Car>();
		    car.Go();
	    }
    }
}
