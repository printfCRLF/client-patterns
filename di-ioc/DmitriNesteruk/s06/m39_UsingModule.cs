using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using DmitriNesteruk.Common.Transportation;

namespace DmitriNesteruk.s06
{
	class m39_UsingModule
	{
		public void Run()
		{
			var builder = new ContainerBuilder();
			builder.RegisterModule(new TransportModule { ObeySpeedLimit = true });
			using (var c = builder.Build())
			{
				c.Resolve<IVehicle>().Go();
			}
		}
	}
}
