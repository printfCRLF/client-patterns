using DmitriNesteruk.Common.Logging;

namespace DmitriNesteruk.Common
{
    public class Car
    {
        private Engine engine;
        private ILog log;

	    public Car(Engine engine)
	    {
		    this.engine = engine;
			this.log = new EmailLog();
	    }

        public Car(Engine engine, ILog log)
        {
            this.engine = engine;
            this.log = log;
        }

        public void Go()
        {
            engine.Ahead(100);
            log.Write("Car going forward...");
        }
    }
}