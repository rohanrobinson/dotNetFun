using Microsoft.AspNetCore.Mvc;

namespace MyBackendAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { message = "First string message!" });
        }
    }
}