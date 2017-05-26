using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApi.BLL
{
    public interface IHelloWorldService<T> where T: class
    {
        IQueryable<T> Get();
    }
}
