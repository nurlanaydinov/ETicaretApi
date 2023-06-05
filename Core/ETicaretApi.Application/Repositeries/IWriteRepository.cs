using ETicaretApi.Domain.Entities.Common;

namespace ETicaretApi.Application.Repositeries
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T entity);
        Task<bool> AddRangeAsync(List<T> datas);
        bool Update(T entity);
        bool Remove(T entity);
        Task<bool> RemoveAsync(string id);
        bool RemoveRange(List<T> datas);
        Task<int> SaveAsync();
    }
}
