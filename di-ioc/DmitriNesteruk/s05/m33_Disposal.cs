using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using DmitriNesteruk.Common.Logging;

namespace DmitriNesteruk.s05
{
    class m33_Disposal
    {
	    public void Run()
	    {
		    var builder = new ContainerBuilder();
		    builder.RegisterType<ConsoleLog>();

		    var container = builder.Build();
		    using (var scope = container.BeginLifetimeScope())
		    {
			    scope.Resolve<ConsoleLog>();
		    }
	    }
    }
}
