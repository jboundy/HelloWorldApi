using System.Threading.Tasks;
using System.Web.Http;

namespace HelloWorld.Api.Controllers
{
    [RoutePrefix("helloworld")]
    public class HelloWorldController : ApiController
    {
       
        [HttpGet]
        public string Get()
        {
            return "Hello World!";
        }

        [HttpPost]
        public async Task<IHttpActionResult> Post<T>([FromBody] T entity)
        {
            return Ok(entity);
        }
    }
}
