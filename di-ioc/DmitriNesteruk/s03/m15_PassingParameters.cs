using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Autofac.Core;
using DmitriNesteruk.Common;
using DmitriNesteruk.Common.Logging;

namespace DmitriNesteruk.s03
{
	class m15_PassingParameters
	{
		public void Run()
		{
			//ResolvedParameterAtRegistrationTime();
			ResolvedParameterAtRunTime();
		}

		private void ResolvedParameterAtRegistrationTime()
		{
			var builder = new ContainerBuilder();
			var mockPhoneNumber = "+046073123456";

			//// named parameter
			//builder.RegisterType<SmsLog>().As<ILog>()
			//	.WithParameter("phoneNumber", mockPhoneNumber);

			//// typed parameter
			//builder.RegisterType<SmsLog>().As<ILog>()
			//	.WithParameter(new TypedParameter(typeof(string), mockPhoneNumber));

			// resolved parameter
			builder.RegisterType<SmsLog>().As<ILog>()
				.WithParameter(new ResolvedParameter(
					// predicate
					(pi, ctx) => pi.ParameterType == typeof(string) && pi.Name == "phoneNumber",
					// value accessor
					(pi, ctx) => mockPhoneNumber
				));

			var container = builder.Build();
			var log = container.Resolve<ILog>();
			log.Write("Text message");
		}

		private void ResolvedParameterAtRunTime()
		{
			var builder = new ContainerBuilder();
			Random random = new Random();
			builder.Register((c, p) => new SmsLog(p.Named<string>("phoneNumber"))).As<ILog>();

			Console.WriteLine("About to build container...");
			var container = builder.Build();
			var log = container.Resolve<ILog>(new NamedParameter("phoneNumber", random.Next().ToString()));
			log.Write("Text message");
		}
	}
}
