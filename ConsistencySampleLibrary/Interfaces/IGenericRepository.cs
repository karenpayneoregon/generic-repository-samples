using System.Linq.Expressions;

namespace ConsistencySampleLibrary.Interfaces;

public interface IGenericRepository<T> where T : class
{
    IEnumerable<T> GetAll();
    Task<List<T>> GetAllAsync();
    T GetById(int id);
    T GetByIdWithIncludes(int id);
    Task<T> GetByIdAsync(int id);
    Task<T> GetByIdWithIncludesAsync(int id);
    bool Remove(int id);
    void Add(in T sender);
    void Update(in T sender);
    int Save();
    Task<int> SaveAsync();
    public T Select(Expression<Func<T, bool>> predicate);
    public Task<T> SelectAsync(Expression<Func<T, bool>> predicate);
}