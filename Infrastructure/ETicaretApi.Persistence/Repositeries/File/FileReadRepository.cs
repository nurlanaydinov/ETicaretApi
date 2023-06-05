using ETicaretApi.Application.Repositeries;
using ETicaretApi.Persistence.Contexts;

namespace ETicaretApi.Persistence.Repositeries
{
    public class FileReadRepository : ReadRepository<Domain.Entities.File>, IFileReadRepository
    {
        public FileReadRepository(ETicaretAPIDbContext context): base(context)
        {
        }
    }
}
