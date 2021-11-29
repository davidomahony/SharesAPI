using Microsoft.AspNetCore.Http;
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
        private readonly BasicStockService basicStocksService;

        public SharesInformationController(ILogger<SharesInformationController> logger, BasicStockService basicStocksService)
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
            if (this.basicStocksService == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            var responseBody = this.basicStocksService.GenerateResults(information);
            return Ok(responseBody);
        }
    }
}
