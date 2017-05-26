using System.Web.Http;
using System.Web.Mvc;
using Autofac;
using HelloWorld.Api.Controllers;
using HelloWorldApi.BLL;
using HelloWorldApi.Core.Application;
using HelloWorldApi.DAL.Models;

namespace HelloWorld.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Settings.Initialize();
            var builder = new ContainerBuilder();
            builder.RegisterType<HelloWorldController>().As<IHelloWorldService<BaseModel>>().InstancePerLifetimeScope();
            builder.Build();

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
