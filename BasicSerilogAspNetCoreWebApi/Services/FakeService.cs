using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace BasicSerilogAspNetCoreWebApi.Services
{
    public class FakeService : IFakeService
    {

        private readonly ILogger<FakeService> _logger;

        public FakeService(ILogger<FakeService> logger)
        {
            _logger = logger;
        }

        public List<string> GetAll()
        {

            _logger.LogInformation("Your custom Log message here");



            return new string[] { "FakeItem1", "FakeItem2", "FakeItem2" }.ToList();
        }

    }
}
