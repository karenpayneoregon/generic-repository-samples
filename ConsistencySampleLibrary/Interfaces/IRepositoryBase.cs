using System.Linq.Expressions;

namespace ConsistencySampleLibrary.Interfaces;
/// <summary>
/// Defines a generic repository interface for performing CRUD operations and querying entities of type <typeparamref name="T"/>.
/// </summary>
/// <typeparam name="T">
/// The type of the entity for which this repository is responsible. Must be a reference type.
/// </typeparam>
public interface IRepositoryBase<T> where T : class
{
    void Add(T objModel);
    void AddRange(IEnumerable<T> objModel);
    T? GetId(int id);
    Task<T?> GetIdAsync(int id);
    T? Get(Expression<Func<T, bool>> predicate);
    Task<T?> GetAsync(Expression<Func<T, bool>> predicate);
    IEnumerable<T> GetList(Expression<Func<T, bool>> predicate);
    Task<IEnumerable<T>> GetListAsync(Expression<Func<T, bool>> predicate);
    IEnumerable<T> GetAll();
    Task<IEnumerable<T>> GetAllAsync();
    int Count();
    Task<int> CountAsync();
    void Update(T objModel);
    void Remove(T objModel);
    void Dispose();
}