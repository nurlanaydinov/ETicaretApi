using ETicaretApi.Application.Repositeries;
using ETicaretApi.Domain.Entities;
using ETicaretApi.Persistence.Contexts;

namespace ETicaretApi.Persistence.Repositeries
{
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}
