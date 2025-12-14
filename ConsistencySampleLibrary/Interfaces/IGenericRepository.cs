using System.Linq.Expressions;

namespace ConsistencySampleLibrary.Interfaces;

/// <summary>
/// Represents a generic repository interface for managing entities of type <typeparamref name="T"/>.
/// </summary>
/// <typeparam name="T">
/// The type of the entity that the repository will manage. Must be a reference type.
/// </typeparam>
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