using System;
using Autofac;
using DmitriNesteruk.Common;

namespace DmitriNesteruk.s02
{
	public class m08_DefaultRegistration
	{
		public void Run()
		{
			var builder = new ContainerBuilder();

			builder.RegisterType<EmailLog>().As<ILog>().As<IConsole>();
			builder.RegisterType<ConsoleLog>().As<ILog>().PreserveExistingDefaults();
			builder.RegisterType<Engine>();
			builder.RegisterType<Car>();

			IContainer container = builder.Build();
			var car = container.Resolve<Car>();

			car.Go();
		}
	}
}
