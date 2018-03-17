using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Autofac;
using Autofac.Configuration;
using DmitriNesteruk.Common.Math;
using Microsoft.Extensions.Configuration;

namespace DmitriNesteruk.s06
{
    public class m40_MicrosoftConfiguration
    {
	    public void Run()
	    {
		    var configBuilder = new ConfigurationBuilder()
			    .SetBasePath(Directory.GetCurrentDirectory())
			    .AddJsonFile("config.json");

		    var configuration = configBuilder.Build();

		    var containerBuilder = new ContainerBuilder();
		    var configModule = new ConfigurationModule(configuration);
		    containerBuilder.RegisterModule(configModule);

		    using (var container = containerBuilder.Build())
		    {
			    float a = 3, b = 4;
			    foreach (IOperation op in container.Resolve<IList<IOperation>>())
			    {
				    Console.WriteLine($"{op.GetType().Name } of {a} and {b} = {op.Calculate(a, b)}");
			    }
		    }

	    }
    }
}
