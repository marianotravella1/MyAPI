using Application.Interfaces;
using Application.Models.Requests;
using Microsoft.AspNetCore.Mvc;

namespace MyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _services;
        public UserController(IUserServices userServices) { _services = userServices; }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_services.Get());
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            return Ok(_services.Get(id));
        }

        [HttpGet("name/{name}")]
        public IActionResult GetByName([FromRoute] string name)
        {
            return Ok(_services.Get(name));
        }

        [HttpPost]
        public IActionResult AddUser([FromBody] UserForCreateDto userDto)
        {
            return Ok(_services.AddUser(userDto));
        }
    }
}
