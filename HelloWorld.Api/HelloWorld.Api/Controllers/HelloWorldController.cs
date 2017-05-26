using System;
using System.Linq;
using System.Web.Http;
using HelloWorldApi.BLL;
using HelloWorldApi.DAL.Models;

namespace HelloWorld.Api.Controllers
{
    [RoutePrefix("helloworld")]
    public class HelloWorldController : ApiController, IHelloWorldService<BaseModel>
    {

        public HelloWorldController()
        {
            
        }

        [HttpGet]
        public string Get()
        {
            return "Hello World!";
        }

        IQueryable<BaseModel> IHelloWorldService<BaseModel>.Get()
        {
            throw new NotImplementedException();
        }
    }
}
