using ConsistencySampleLibrary.Interfaces;
using System.Linq.Expressions;
using ConsistencySampleLibrary.Models;
using ConsistencySampleLibrary.Data;
using Microsoft.EntityFrameworkCore;

namespace ConsistencySampleLibrary.Repositories;

/// <summary>
/// Just enough coded for demonstration in frontend sample project.
/// </summary>
public class CountryRepository : IGenericRepository<Countries>
{
    private Context _context;

    public CountryRepository(Context context)
    {
        _context = context;
    }

    public IEnumerable<Countries> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<List<Countries>> GetAllAsync()
    {
        return _context.Countries.ToListAsync();
    }

    public Countries GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Countries GetByIdWithIncludes(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Countries> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Countries> GetByIdWithIncludesAsync(int id)
    {
        throw new NotImplementedException();
    }

    public bool Remove(int id)
    {
        throw new NotImplementedException();
    }

    public void Add(in Countries sender)
    {
        throw new NotImplementedException();
    }

    public void Update(in Countries sender)
    {
        throw new NotImplementedException();
    }

    public int Save()
    {
        throw new NotImplementedException();
    }

    public Task<int> SaveAsync()
    {
        throw new NotImplementedException();
    }

    public Countries Select(Expression<Func<Countries, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public Task<Countries> SelectAsync(Expression<Func<Countries, bool>> predicate)
    {
        throw new NotImplementedException();
    }
}
