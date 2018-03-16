using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using DmitriNesteruk.Common;

namespace DmitriNesteruk.s02
{
	class m09_ChoiceOfConstructor
	{
		public void Run()
		{
			var builder = new ContainerBuilder();
			builder.RegisterType<ConsoleLog>().As<ILog>();
			builder.RegisterType<Car>()
				.UsingConstructor(typeof(Engine));
			builder.RegisterType<Engine>();

			var container = builder.Build();
			var car = container.Resolve<Car>();
			car.Go();
		}
	}
}
