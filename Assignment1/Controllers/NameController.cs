using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Assignment1.Models;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NameController : ControllerBase
    {
        [HttpGet("GetName/{name?}")]
        public string GetName(string name = "Nhi")
        {
            return $"My name is: {name}.";
        }

        [HttpPost("AddName")]
        public string AddName(Name name)
        {   
            return name.MyName;
        }
    }
}