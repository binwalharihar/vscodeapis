using Microsoft.AspNetCore.Mvc;
namespace VSCODEWEBAPI.Controllers
{
    [ApiController]
    [Route("vs/v2/weathertypes")]

    public class HomeController : ControllerBase
    {
        private static readonly string[] Summaries =
        [
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        ];
        [HttpGet("getlist")]
        public async Task<IActionResult> FirstAPI()
        {
            try
            {
                return Ok(Summaries);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(string username,string password)
        {
            try
            {
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
