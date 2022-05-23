using Autofac;
using DataBase;
using Repository;

namespace UoW
{
    public class UoWModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().SingleInstance();
            builder.RegisterType<DeliveryContext>().SingleInstance();
            builder.RegisterType<ContextRepository<Delivery>>().As<IGenericRepository<Delivery>>().SingleInstance();
            builder.RegisterType<ContextRepository<Food>>().As<IGenericRepository<Food>>().SingleInstance();
            builder.RegisterType<ContextRepository<Set>>().As<IGenericRepository<Set>>().SingleInstance();
        }
    }
}
