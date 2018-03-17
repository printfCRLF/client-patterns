using System;
using System.Collections.Generic;
using System.Text;
using Autofac;

namespace DmitriNesteruk.s05
{
	public class Startup : IStartable
	{
		public Startup()
		{

		}

		public void Start()
		{
			Console.WriteLine("Container being built");
		}
	}

	class m35_RunningCodeAtStartup
	{
		public void Run()
		{
			var builder = new ContainerBuilder();
			builder.RegisterType<Startup>().As<Startup>()
				.As<IStartable>()
				.SingleInstance();

			using (var c = builder.Build())
			{
				c.Resolve<Startup>();
			}

		}
	}
}
