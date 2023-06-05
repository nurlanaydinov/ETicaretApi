using ETicaretApi.Domain.Entities.Common;
using System.Linq.Expressions;

namespace ETicaretApi.Application.Repositeries
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll(bool tracking = true);
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true);
        Task<T> GetByIdasync(string id, bool tracking = true);
    }
}
