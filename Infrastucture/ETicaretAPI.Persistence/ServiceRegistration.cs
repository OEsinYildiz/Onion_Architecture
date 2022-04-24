using ETicaret.Application.Abstractions;
using ETicaretAPI.Persistence.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaretAPI.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection service)
    {
        service.AddSingleton<IProductService, ProductService>();
    }
}