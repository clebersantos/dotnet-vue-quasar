using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController: Controller
    {

        public AlunoController()
        {
            
        }
        
        [HttpGet]
        public IActionResult get()
        {
            return Ok();
        }


        [HttpGet("{AlunoId}")]
        public IActionResult get(int AlunoId)
        {
            return Ok();
        }


        [HttpPost]
        public IActionResult post()
        {
            return Ok();
        }


        [HttpPost("{AlunoId}")]
        public IActionResult put(int AlunoId)
        {
            return Ok();
        }


        [HttpDelete("{AlunoId}")]
        public IActionResult delete(int AlunoId)
        {
            return Ok();
        }
    }
}