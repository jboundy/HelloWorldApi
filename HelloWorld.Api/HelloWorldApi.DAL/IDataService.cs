using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApi.DAL
{
    public interface IDataService
    {
        Task Commit();
    }
}
