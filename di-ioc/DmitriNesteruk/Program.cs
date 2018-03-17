using System;
using DmitriNesteruk.s02;
using DmitriNesteruk.s03;
using DmitriNesteruk.s04;

namespace DmitriNesteruk
{
    class Program
    {
        static void Main(string[] args)
        {
			// -- section 02
			//new m06_ScenarioWithoutDi().Run();
			//new m07_RegisteringTypes().Run();
			//new m08_DefaultRegistration().Run();
			//new m09_ChoiceOfConstructor().Run();
			//new m10_RegisteringInstances().Run();
			//new m11_LambdaExpressionComponents().Run();
			//new m12_OpenGenericComponents().Run();

			// -- section 03
			//new m15_PassingParameters().Run();
			//new m16_PropertyMethodInjection().Run();
	        //new m17_ScanningForTypes().Run();
			//new m18_ScanningForModules().Run();
			
			// -- section 04
			//new m21_DelayedInstantiation().Run();
			//new m22_ControlledInstantiation().Run();
			new m23_DynamicInstantiation().Run();

			// -- section 05
		}
	}
}