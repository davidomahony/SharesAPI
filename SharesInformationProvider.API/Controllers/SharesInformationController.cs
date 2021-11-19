using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SharesInformationProvider.API.Services;
using SharesInformationProvider.Models;

namespace SharesInformationProvider.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SharesInformationController : ControllerBase
    {
        private readonly ILogger logger;
        private readonly BasicStocksService basicStocksService;

        public SharesInformationController(ILogger<SharesInformationController> logger, BasicStocksService basicStocksService)
        {
            this.logger = logger;
            this.basicStocksService = basicStocksService;
        }

        [HttpGet]
        [Route("Information")]
        public IActionResult Information()
        {
            return Ok($"Will populate later but all you need to knwo is I am alive");
        }

        [HttpGet]
        [Route("BasicQuery")]
        public IActionResult BasicQuery([FromQuery] BasicSharesQueryInfo information)
        {
            return Ok($"Comapny: {information.ListingName}");
        }
    }
}
