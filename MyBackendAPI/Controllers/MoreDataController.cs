using Microsoft.AspNetCore.Mvc;

namespace MyBackendAPI.Controllers

{
    [ApiController]
    [Route("[controller]")]
    public class MoreDataController: ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { message = "Second string message!!"});
        }
    }
}