using Autofac;
using Tmag.Common.Repositories;

namespace Tmag.ConsumerData
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<ConsumerDataRepository>()
                .As<IRepository>().InstancePerLifetimeScope();
        }
    }
}

