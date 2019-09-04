using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace BasicSerilogAspNetCoreWebApi.Services
{
    public interface IFakeService
    {
        List<string> GetAll();
    }
}
