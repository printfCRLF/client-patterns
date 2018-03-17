using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using DmitriNesteruk.Common.Resources;

namespace DmitriNesteruk.s05
{
    class m32_CaptiveDependencies
    {
	    public void Run()
	    {
		    var builder = new ContainerBuilder();

		    builder.RegisterType<ResourceManager>().SingleInstance();
		    builder.RegisterType<SingletonResource>().As<IResource>().SingleInstance();
		    builder.RegisterType<InstancePerDependencyResource>().As<IResource>();

		    using (var c = builder.Build())
		    {
			    using (var scope = c.BeginLifetimeScope())
			    {
				    scope.Resolve<ResourceManager>();
			    }
		    }
	    }
    }
}
