using ETicaretApi.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace ETicaretApi.Application.Repositeries
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }
    }
}
