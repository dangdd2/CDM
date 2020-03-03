using Autofac;

namespace Tmag.Identity
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<Tmag.Identity.Context>()
                .AsSelf().InstancePerLifetimeScope();
            builder
                .RegisterType<Tmag.Identity.UserClaimResolver>()
                .As<IUserClaimResolver>().InstancePerLifetimeScope();
            builder
                .RegisterType<Tmag.Identity.UserIdResolver>()
                .As<IUserIdResolver>().InstancePerLifetimeScope();

        }
    }
}

