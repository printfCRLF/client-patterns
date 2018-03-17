using System;
using System.Collections.Generic;
using System.Text;

namespace DmitriNesteruk.Common.Resources
{
	public class ResourceManager
	{
		public IEnumerable<IResource> Resources { get; set; }

		public ResourceManager(IEnumerable<IResource> resources)
		{
			Resources = resources;
		}
	}
}
