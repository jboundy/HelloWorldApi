using System.Web.Http;
using System.Web.Mvc;
using Autofac;
using HelloWorldApi.Core.Application;
using HelloWorldApi.DAL;

namespace HelloWorld.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Settings.Initialize();
            var builder = new ContainerBuilder();
            builder.RegisterType<EntityContext>().As<IDataService>().InstancePerLifetimeScope();
            builder.Build();
            
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
