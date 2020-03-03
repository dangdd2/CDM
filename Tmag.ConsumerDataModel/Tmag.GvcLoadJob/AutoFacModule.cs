using Autofac;

namespace Tmag.GvcLoadJob
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<Clubs>()
                .AsSelf().InstancePerLifetimeScope();
            builder
                .RegisterType<Repository>()
                .AsSelf().InstancePerLifetimeScope();
        }
    }
}

