using Microsoft.AspNetCore.Mvc;
using Homework_class02.Data;

namespace Homework_class02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet("getAllUser")]
        public ActionResult GetAll()
        {
            return Ok(StaticDB.userNames);
        }

        [HttpGet("{id}")] 
        public ActionResult Get(int id)
        {
            if (id < 0 || id > StaticDB.userNames.Count)
            {
                return NotFound("The provided ID is not valid.");
            }
            string value = StaticDB.userNames[id];
            return Ok(value);
        }
    }
}

