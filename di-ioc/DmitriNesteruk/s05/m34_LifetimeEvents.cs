using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using DmitriNesteruk.Common.Family;
using DmitriNesteruk.Common.Logging;

namespace DmitriNesteruk.s05
{
	class m34_LifetimeEvents
	{
		public void Run()
		{
			var builder = new ContainerBuilder();
			builder.RegisterType<Parent>();
			builder.RegisterType<Child>()
				.OnActivating(a =>
				{
					Console.WriteLine("Child activating");
					//a.Instance.Parent = a.Context.Resolve<Parent>();
					a.ReplaceInstance(new BadChild());
				})
				.OnActivated(a =>
				{
					Console.WriteLine("Child activated");
				})
				.OnRelease(a =>
				{
					Console.WriteLine("Child is about to be released");
				});

			// Runtime exception
			//builder.RegisterType<ConsoleLog>()
			//	.As<ILog>()
			//	.OnActivating(a =>
			//	{
			//		a.ReplaceInstance(new SmsLog("+123456789"));
			//	});

			builder.RegisterType<ConsoleLog>().AsSelf();
			builder.Register<ILog>(c => c.Resolve<ConsoleLog>())
				.OnActivating(a => a.ReplaceInstance(new SmsLog("+123456789")));

			using (var scope = builder.Build().BeginLifetimeScope())
			{
				var child = scope.Resolve<Child>();
				var parent = child.Parent;
				Console.WriteLine(child);
				Console.WriteLine(parent);

				var log = scope.Resolve<ILog>();
				log.Write("Testing");
			}
		}
	}
}
