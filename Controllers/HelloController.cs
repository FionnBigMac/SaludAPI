using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SaludAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public async Task<string> Hola()
        {
            return "Hola Javier";
        }
    }
}
