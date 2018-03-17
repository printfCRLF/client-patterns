using System;
using System.Collections.Generic;
using System.Text;
using Autofac;

namespace DmitriNesteruk.Common.Family
{
	class FamilyModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<Parent>();
			builder.Register(c => new Child { Parent = c.Resolve<Parent>() });
		}
	}
}
