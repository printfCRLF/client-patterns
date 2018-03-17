using System;
using System.Collections.Generic;
using System.Text;

namespace DmitriNesteruk.Common.Math
{
    class Addition: IOperation
    {
	    public float Calculate(float a, float b)
	    {
		    return a + b;
	    }
    }
}
