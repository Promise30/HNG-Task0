using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HNG_Task0_PublicAPIService.Controllers
{
    [Route("api/")]
    [ApiController]
    public class BasicInfoController : ControllerBase
    {
        [Route("basic-info")]
        [HttpGet]
        public IActionResult Get()
        {
            var basicInfo = new
            {
                email = "promiseadeagbo@gmail.com",
                current_datetime = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ssZ"),
                github_url = "https://github.com/Promise30/HNG-Task0"
            };
            return Ok(basicInfo);
        }
    }
}
