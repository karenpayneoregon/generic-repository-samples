using System.Linq.Expressions;

namespace ConsistencySampleLibrary.Interfaces;
/// <summary>
/// Part of a solution on Stackoverflow for web
/// https://stackoverflow.com/a/55664975/5509738
/// </summary>
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