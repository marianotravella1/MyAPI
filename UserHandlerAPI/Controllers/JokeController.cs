using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace UserHandlerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JokeController : ControllerBase
    {
        private readonly IJokeService _jokeService;

        public JokeController(IJokeService jokeService)
        {
            _jokeService = jokeService;
        }

        [HttpGet("random")]
        public async Task<ActionResult<List<Joke>>> GetRandomJokes()
        {
            try
            {
                var jokes = await _jokeService.GetRandomJokesAsync();
                
                if (jokes == null || !jokes.Any())
                {
                    return NotFound("No se pudieron obtener chistes en este momento.");
                }

                return Ok(jokes);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno del servidor: {ex.Message}");
            }
        }
    }
}