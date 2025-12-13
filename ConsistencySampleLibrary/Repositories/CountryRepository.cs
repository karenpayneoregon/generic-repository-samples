using ConsistencySampleLibrary.Interfaces;
using System.Linq.Expressions;
using ConsistencySampleLibrary.Models;
using ConsistencySampleLibrary.Data;
using Microsoft.EntityFrameworkCore;
#pragma warning disable CS8603 // Possible null reference return.

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
        return _context.Countries.FirstOrDefault(c => c.Id == id);
    }

    public Countries GetByIdWithIncludes(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Countries> GetByIdAsync(int id)
    {
        return _context.Countries.FirstOrDefaultAsync(c => c.Id == id)!;
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
        _context.Countries.Add(sender).State = EntityState.Added;
    }

    public void Update(in Countries sender)
    {
        _context.Countries.Update(sender);
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
