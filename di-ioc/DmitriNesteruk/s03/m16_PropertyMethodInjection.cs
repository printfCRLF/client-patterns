using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using DmitriNesteruk.Common.Family;

namespace DmitriNesteruk.s03
{
	class m16_PropertyMethodInjection
	{
		public void Run()
		{
			var builder = new ContainerBuilder();
			builder.RegisterType<Parent>();
			//builder.RegisterType<Child>().PropertiesAutowired();

			//builder.RegisterType<Child>().WithProperty("Parent", new Parent());

			builder.Register(c =>
			{
				var child = new Child();
				child.SetParent(c.Resolve<Parent>());
				return child;
			});

			var container = builder.Build();
			var parent = container.Resolve<Child>().Parent;
			Console.WriteLine(parent);
		}
	}
}
