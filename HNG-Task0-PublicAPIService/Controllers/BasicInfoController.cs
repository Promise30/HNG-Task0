using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HNG_Task0_PublicAPIService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasicInfoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var basicInfo = 
            return Ok(basicInfo);
        }
    }
}
