using System;
using System.Collections.Generic;
using System.Text;

namespace DmitriNesteruk.Common.Transportation
{
    public class Truck: IVehicle
    {
	    private readonly IDriver driver;

	    public Truck(IDriver driver)
	    {
		    this.driver = driver;
	    }

	    public void Go()
	    {
		    driver.Drive();
	    }
    }
}
