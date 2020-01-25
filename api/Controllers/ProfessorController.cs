using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController: Controller
    {
        public ProfessorController()
        {
            
        }
        
        [HttpGet]
        public IActionResult get()
        {
            return Ok();
        }


        [HttpGet("{ProfessorId}")]
        public IActionResult get(int ProfessorId)
        {
            return Ok();
        }


        [HttpPost]
        public IActionResult post()
        {
            return Ok();
        }


        [HttpPost("{ProfessorId}")]
        public IActionResult put()
        {
            return Ok();
        }


        [HttpDelete("{ProfessorId}")]
        public IActionResult delete()
        {
            return Ok();
        }
    }
}