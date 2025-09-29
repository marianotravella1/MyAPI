using Domain.Entities;

namespace Application.Interfaces
{
    public interface IJokeService
    {
        Task<List<Joke>?> GetRandomJokesAsync();
    }
}