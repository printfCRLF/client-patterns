using System;
using System.Collections.Generic;
using System.Text;

namespace DmitriNesteruk.Common.Transportation
{
    class CrazyDriver: IDriver
    {
	    public CrazyDriver()
	    {
		    
	    }

	    public void Drive()
	    {
		    Console.WriteLine("Going too fast and crashing into a tree");
	    }
    }
}
