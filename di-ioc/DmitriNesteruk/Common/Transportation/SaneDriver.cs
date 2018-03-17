using System;
using System.Collections.Generic;
using System.Text;

namespace DmitriNesteruk.Common.Transportation
{
	class SaneDriver : IDriver
	{
		public SaneDriver()
		{
		}

		public void Drive()
		{
			Console.WriteLine("Driving safely to destination");
		}
	}
}
