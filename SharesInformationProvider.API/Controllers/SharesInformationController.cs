using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SharesInformationProvider.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SharesInformationController : ControllerBase
    {
        private readonly ILogger logger;

        public SharesInformationController(ILogger<SharesInformationController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public IActionResult Information()
        {
            return Ok($"Will populate later but all you need to knwo is I am alive");
        }
    }
}
