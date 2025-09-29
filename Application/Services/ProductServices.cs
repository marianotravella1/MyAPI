using Application.Interfaces;
using Application.Models.Requests;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class ProductServices : IProductServices
    {
        private readonly IProductRepository _repository;

        public ProductServices(IProductRepository repository)
        {
            _repository = repository;
        }

        public List<Product> Get()
        {
            return _repository.Get();
        }

        public Product? Get(int id)
        {
            return _repository.Get(id);
        }

        public Product? Get(string name)
        {
            return _repository.Get(name);
        }

        public int AddProduct(ProductForCreateDto productDto)
        {
            Product product = new Product()
            {
                Name = productDto.Name,
                Description = productDto.Description,
                Price = productDto.Price
            };

            return _repository.Add(product).Id;
        }
    }
}
