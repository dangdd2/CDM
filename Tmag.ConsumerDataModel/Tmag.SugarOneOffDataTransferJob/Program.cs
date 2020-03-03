using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Linq;
using Tmag.Common;

namespace Tmag.SugarOneOffDataTransferJob
{
    class Program
    {
        private static IContainer Container { get; set; }
        private static IConfigurationRoot Configuration;
        static void Main(string[] args)
        {
            var provider = Configure();

            //var staticTables = provider.GetService<StaticTables>();
            //staticTables.Migrate();

            //var consumer = provider.GetService<Consumer>();
            //consumer.Migrate();

            //var whatsInTheBag = provider.GetService<WhatsInTheBag>();
            //whatsInTheBag.Migrate();

            var experiences = provider.GetService<Experiences>();
            experiences.Migrate();
        }

        private static AutofacServiceProvider Configure()
        {

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");


            Configuration = builder.Build();


            ILoggerFactory loggerFactory = new LoggerFactory()

            .AddConsole(Configuration.GetSection("Logging"))
            .AddDebug()
            .AddConsole();

            var serviceCollection = new ServiceCollection();

            serviceCollection.AddOptions();
            serviceCollection.Configure<ConnectionStrings>(Configuration.GetSection("ConnectionStrings"));
            serviceCollection.Configure<LoadSettings>(Configuration.GetSection("LoadSettings"));
            serviceCollection.AddSingleton(loggerFactory); // Add first my already configured instance
            serviceCollection.AddLogging();

            var autoBuilder = new ContainerBuilder();

            autoBuilder.Populate(serviceCollection);
            var diHelper = new DiHelper();
            var diAssemblies = Configuration.GetValue<string>("DiAssemblies:List");
            var assemblies = diHelper.GetAssemblies(diAssemblies.Split(',').ToList());
            //  Console.Write(diAssemblies);
            autoBuilder.RegisterAssemblyModules(assemblies);

            Container = autoBuilder.Build();

            // Create the IServiceProvider based on the container.
            return new AutofacServiceProvider(Container);
        }
    }
}
