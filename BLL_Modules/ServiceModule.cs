using Autofac;
using UoW;

namespace BLL
{
    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DeliveryService>().As<IService<DeliveryClass>>().SingleInstance();
            builder.RegisterType<FoodService>().As<IService<FoodClass>>().SingleInstance(); ;
            builder.RegisterType<SetService>().As<IService<SetClass>>().SingleInstance();
            builder.RegisterModule<UoWModule>();
            builder.RegisterModule<MappingModule>();
        }
    }
}
