using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using DmitriNesteruk.Common.Logging;

namespace DmitriNesteruk.s05
{
	class m31_InstanceScope
	{
		public void Run()
		{
			//SingleInstance();
			//InstancePerScope();
			NamedLifetimeScope();
		}

		private void SingleInstance()
		{
			var builder = new ContainerBuilder();
			builder.RegisterType<ConsoleLog>().As<ILog>()
				.SingleInstance();
			//.InstancePerDependencyResource();

			var container = builder.Build();

			using (var scope = container.BeginLifetimeScope())
			{
				var log = scope.Resolve<ILog>();
				log.Write("Testing");
				scope.Resolve<ILog>();
			}
		}

		private void InstancePerScope()
		{
			var builder = new ContainerBuilder();
			builder.RegisterType<ConsoleLog>().As<ILog>()
				.InstancePerLifetimeScope();
			//.InstancePerDependencyResource();

			var container = builder.Build();

			using (var scope1 = container.BeginLifetimeScope())
			{
				for (int i = 0; i < 3; i++)
				{
					scope1.Resolve<ILog>();
				}
			}

			using (var scope2 = container.BeginLifetimeScope())
			{
				for (int i = 0; i < 3; i++)
				{
					scope2.Resolve<ILog>();
				}
			}
		}

		private void NamedLifetimeScope()
		{
			var builder = new ContainerBuilder();
			builder.RegisterType<ConsoleLog>().As<ILog>()
				.InstancePerMatchingLifetimeScope("foo");
			//.InstancePerDependencyResource();

			var container = builder.Build();

			using (var scope1 = container.BeginLifetimeScope("foo"))
			{
				for (int i = 0; i < 3; i++)
				{
					scope1.Resolve<ILog>();
				}

				using (var scope2 = scope1.BeginLifetimeScope())
				{
					for (int i = 0; i < 3; i++)
					{
						scope2.Resolve<ILog>();
					}
				}
			}


		}
	}
}
