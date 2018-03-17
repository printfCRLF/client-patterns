using System;

namespace DmitriNesteruk.Common.Family
{
	class Child
	{
		public string Name { get; set; }
		public Parent Parent { get; set; }

		public void SetParent(Parent parent)
		{
			Parent = parent;
		}

		public Child()
		{
			Console.WriteLine("Child being created");
		}

		public override string ToString()
		{
			return "Hi there";
		}
	}
}