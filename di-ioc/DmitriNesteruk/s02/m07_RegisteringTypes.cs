using System;
using Autofac;

namespace DmitriNesteruk.s02
{   
    public class m07_RegisteringTypes
    {
        public void Run()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ConsoleLog>().As<ILog>().AsSelf();
            builder.RegisterType<Engine>();
            builder.RegisterType<Car>();

            IContainer container = builder.Build();
            var car = container.Resolve<Car>();

            var log = container.Resolve<ConsoleLog>();
            
            car.Go();
        }
    }
}
