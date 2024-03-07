namespace Domain.Interface.Repository.Common
{
    public interface IBaseRepository<T>
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByUuidAsync(Guid uuid);
        Task<T> GetByIdAsync(Int64 id);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(Guid uuid);
    }
}
