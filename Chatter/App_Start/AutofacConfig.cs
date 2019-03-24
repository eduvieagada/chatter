using Autofac;
using Autofac.Integration.WebApi;
using Chatter.Data;
using Chatter.Logic;
using System.Configuration;
using System.Reflection;
using System.Web.Http;

namespace Chatter.App_Start
{
    public class AutofacConfig
    {
        public static IContainer container;

        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()));
        }

        public static void Initialize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<NewsContainer>().As<INewsContainer>()
                .InstancePerRequest()
                .WithParameter(new TypedParameter(typeof(string), ConfigurationManager.AppSettings.Get("ApiKey")));
            builder.RegisterType<Logging>().As<ILoggging>().InstancePerRequest();

            container = builder.Build();

            return container;
        }
    }

    public class Bootstrapper
    {
        public static void Run()
        {
            AutofacConfig.Initialize(GlobalConfiguration.Configuration);
        }
    }
}