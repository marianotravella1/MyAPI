using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly ApplicationContext _context;
        public UserRepository(ApplicationContext context) : base(context)
        { 
            _context = context; 
        }

        public User? Get(string name)
        {
            return _context.Users.FirstOrDefault(u => u.Username == name);
        }
    }
}
