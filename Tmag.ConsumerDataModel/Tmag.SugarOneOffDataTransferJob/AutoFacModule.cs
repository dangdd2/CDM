using Autofac;
using Tmag.SugarOneOffDataTransferJob.Models;

namespace Tmag.SugarOneOffDataTransferJob
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<Consumer>()
                .AsSelf().InstancePerLifetimeScope();
            builder
                .RegisterType<WhatsInTheBag>()
                .AsSelf().InstancePerLifetimeScope();

            builder
                .RegisterType<SugarDataContext>()
                .AsSelf().InstancePerLifetimeScope();
            builder
                .RegisterType<StaticTables>()
                .AsSelf().InstancePerLifetimeScope();
            builder
                .RegisterType<Experiences>()
                .AsSelf().InstancePerLifetimeScope();
            builder
                .RegisterType<StaticTableHelper>()
                .AsSelf().InstancePerLifetimeScope();

        }
    }
}

