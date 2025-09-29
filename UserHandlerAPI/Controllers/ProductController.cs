using Application.Interfaces;
using Application.Models.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductServices _services;
        public ProductController(IProductServices services)
        {
            _services = services;
        }
        [Authorize]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_services.Get());
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute]int id)
        {
            return Ok(_services.Get(id));
        }

        [HttpGet("name")]
        public IActionResult Get([FromRoute] string name)
        {
            return Ok(_services.Get(name));
        }

        [HttpPost]
        public IActionResult Add([FromBody] ProductForCreateDto dto)
        {
            return Ok(_services.AddProduct(dto));
        }
    }
}
