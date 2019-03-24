using Autofac;
using Autofac.Integration.WebApi;
using Chatter.Data;
using Chatter.Logic;
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

            builder.RegisterType<INewsContainer>().As<NewsContainer>().InstancePerRequest();
            builder.RegisterType<ILoggging>().As<Logging>().InstancePerRequest();

            container = builder.Build();

            return container;
        }
    }
}