namespace DmitriNesteruk.s03
{
	class Child
	{
		public string Name { get; set; }
		public Parent Parent { get; set; }

		public void SetParent(Parent parent)
		{
			Parent = parent;
		}
	}
}