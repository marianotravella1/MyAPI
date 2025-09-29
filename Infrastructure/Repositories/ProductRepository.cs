using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        private readonly ApplicationContext _context;
        public ProductRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }

        public Product? Get(string name)
        {
            return _context.Products.FirstOrDefault(p => p.Name == name);
        }
    }
}
