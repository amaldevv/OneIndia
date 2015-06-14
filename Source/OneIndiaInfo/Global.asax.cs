using Autofac;
using Autofac.Integration.Mvc;
using OneIndiaInfo.APIClient;
using OneIndiaInfo.Interfaces.APIClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace OneIndiaInfo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<OpenDataDistrictClient>()
                .As<IOpenDataDistrictClient>()
                .InstancePerRequest();
            builder.RegisterType<OpenDataPostOfficeClient>()
                .As<IOpenDataPostOfficeClient>()
                .InstancePerRequest();

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
