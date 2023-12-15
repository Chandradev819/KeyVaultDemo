using Microsoft.AspNetCore.Mvc;


namespace KeyVaultDemo
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        // GET: api/<HomeController>
        //[HttpGet]
        //public async Task<string> Get()
        //{

        //}
    }
}
