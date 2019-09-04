
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicSerilogAspNetCoreWebApi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BasicSerilogAspNetCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {


        private readonly IFakeService _fakeService;

        public ValuesController(IFakeService fakeService)
        {
            _fakeService = fakeService;
        }


        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {

            return _fakeService.GetAll();
        }


    }
}
