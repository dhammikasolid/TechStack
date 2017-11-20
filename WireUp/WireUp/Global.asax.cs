using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using DomainServices;
using System.Reflection;
using System.Web.Configuration;
using System;

namespace WireUp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // IOC Config <

            var builder = new ContainerBuilder();

            var assembly = typeof(MvcApplication).Assembly;

            // Module Config <<

            builder.RegisterControllers(assembly);
            builder.RegisterApiControllers(assembly);

            var servicesAssembly = typeof(Service).Assembly;

            builder.RegisterType<Service>().AsImplementedInterfaces();

            if ((Convert.ToBoolean(WebConfigurationManager.AppSettings["Is1000Enabled"])) == true)
                builder.RegisterAssemblyTypes(servicesAssembly)
                       .Where(t => t.BaseType == typeof(BaseService1000))
                       .AsImplementedInterfaces();
            if (Convert.ToBoolean(WebConfigurationManager.AppSettings["Is2000Enabled"]) == true)
                builder.RegisterAssemblyTypes(servicesAssembly)
                       .Where(t => t.BaseType == typeof(BaseService2000))
                       .AsImplementedInterfaces();
            
            // >> Module Config

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            // > IOC Config
        }
    }
}
