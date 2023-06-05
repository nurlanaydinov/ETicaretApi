using ETicaretApi.Application.Repositeries;
using ETicaretApi.Domain.Entities;
using ETicaretApi.Persistence.Contexts;

namespace ETicaretApi.Persistence.Repositeries
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}
