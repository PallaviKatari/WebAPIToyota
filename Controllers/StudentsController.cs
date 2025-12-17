using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        //Action Verbs
        // GET, POST, PUT, DELETE
        [HttpGet]
        public List<string> Get()
        {
            return new List<string> { "Student1", "Student2", "Student3" };
        }
    }
}
