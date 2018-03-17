using System;
using System.Collections.Generic;
using System.Text;
using Autofac;

namespace DmitriNesteruk.Common.Transportation
{
	class TransportModule : Module
	{
		public bool ObeySpeedLimit { get; set; }

		protected override void Load(ContainerBuilder builder)
		{
			if (ObeySpeedLimit)
			{
				builder.RegisterType<SaneDriver>().As<IDriver>();
			}
			else
			{
				builder.RegisterType<CrazyDriver>().As<IDriver>();
			}

			builder.RegisterType<Truck>().As<IVehicle>();
		}
	}
}
