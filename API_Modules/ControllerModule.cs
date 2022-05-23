using Autofac;
using BLL;

namespace API
{
    public class ControllerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DeliveryController>().As<IController<DeliveryModel>>().SingleInstance();
            builder.RegisterType<FoodController>().As<IController<FoodModel>>().SingleInstance();
            builder.RegisterType<SetController>().As<IController<SetModel>>().SingleInstance();
            builder.RegisterModule<ServiceModule>();
        }
    }
}
