using ETicaret.Application.Abstractions;
using ETicaretAPI.Domain.Entities;

namespace ETicaretAPI.Persistence.Concrete;

public class ProductService : IProductService
{
    public List<Product> GetAllProducts() 
        => new List<Product>
        {
            new() {Id = Guid.NewGuid(), Name = "Product 1", Price = 10000, Stock = 10},
            new() {Id = Guid.NewGuid(), Name = "Product 2", Price = 12000, Stock = 12},
            new() {Id = Guid.NewGuid(), Name = "Product 3", Price = 13000, Stock = 13},
            new() {Id = Guid.NewGuid(), Name = "Product 4", Price = 14000, Stock = 14},
        };
}