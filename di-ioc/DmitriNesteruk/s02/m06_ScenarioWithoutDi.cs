using DmitriNesteruk.Common;
using DmitriNesteruk.Common.Logging;

namespace DmitriNesteruk.s02
{
	public class m06_ScenarioWithoutDi
	{
		public void Run()
		{
			var log = new ConsoleLog();
			var engine = new Engine(log);
			var car = new Car(engine, log);

			car.Go();
		}
	}
}