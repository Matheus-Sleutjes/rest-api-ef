using Microsoft.AspNetCore.Mvc;

namespace RestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LivrosController : ControllerBase
    {
        public LivrosController()
        {
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello world!");
        }
    }
}
