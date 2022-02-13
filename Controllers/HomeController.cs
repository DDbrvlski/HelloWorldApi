using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpGet(Name = "GetHello")]
        public string Get()
        {
            return "Hello Damian";
        }
    }
}
