using ETicaretApi.Application.Repositeries;
using ETicaretApi.Persistence.Contexts;

namespace ETicaretApi.Persistence.Repositeries
{
    public class ProductImageFileReadRepository : ReadRepository<Domain.Entities.ProductImageFile>, IProductImageFileReadRepository
    {
        public ProductImageFileReadRepository(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}
