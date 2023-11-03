using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreLearning.API.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllStudent()
        {
            string[] studentsName = new string[] { "jay", "Ravi", "Kishan", "Smit", "Jalay", "Dhvani" };

            return Ok(studentsName);
        
        }
    }
}
 