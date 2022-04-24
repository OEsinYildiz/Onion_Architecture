using ETicaretAPI.Domain.Entities;

namespace ETicaret.Application.Abstractions;

public interface IProductService
{
    List<Product> GetAllProducts();
}