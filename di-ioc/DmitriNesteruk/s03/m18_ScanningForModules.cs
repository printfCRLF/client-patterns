using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using DmitriNesteruk.Common.Family;

namespace DmitriNesteruk.s03
{
    class m18_ScanningForModules
    {
	    public void Run()
	    {
		    var builder = new ContainerBuilder();
		    builder.RegisterAssemblyModules<FamilyModule>(typeof(m18_ScanningForModules).Assembly);

		    var container = builder.Build();
		    var parent = container.Resolve<Child>().Parent;
			Console.WriteLine(parent);
	    }
    }
}
