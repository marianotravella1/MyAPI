using Application.Models.Requests;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IProductServices
    {
        List<Product> Get();
        Product? Get(int id);
        int AddProduct(ProductForCreateDto productDto);
        Product? Get(string name);
    }
}
