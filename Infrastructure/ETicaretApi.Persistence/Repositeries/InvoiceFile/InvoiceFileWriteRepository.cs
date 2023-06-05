using ETicaretApi.Application.Repositeries;
using ETicaretApi.Persistence.Contexts;

namespace ETicaretApi.Persistence.Repositeries
{
    public class InvoiceFileWriteRepository : WriteRepository<Domain.Entities.InvoiceFile>, IInvoiceFileWriteRepository
    {
        public InvoiceFileWriteRepository(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}
