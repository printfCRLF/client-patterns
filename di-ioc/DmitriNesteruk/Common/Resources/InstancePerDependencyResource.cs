using System;
using System.Collections.Generic;
using System.Text;

namespace DmitriNesteruk.Common.Resources
{
	class InstancePerDependencyResource : IResource, IDisposable
	{
		public InstancePerDependencyResource()
		{
			Console.WriteLine("Instance per dependency created");
		}

		public void Dispose()
		{
			Console.WriteLine("Instance per dependency disposed");
		}
	}
}
