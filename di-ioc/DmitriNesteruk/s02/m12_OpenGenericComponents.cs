using System;
using System.Collections.Generic;
using System.Text;
using Autofac;

namespace DmitriNesteruk.s02
{
    class m12_OpenGenericComponents
    {
		public void Run()
		{
			var builder = new ContainerBuilder();
			// IList<T> --> List<T>
			builder.RegisterGeneric(typeof(List<>)).As(typeof(IList<>));

			var container = builder.Build();
			var myList = container.Resolve<IList<int>>();
			Console.WriteLine(myList.GetType().Name);

		}

    }
}
