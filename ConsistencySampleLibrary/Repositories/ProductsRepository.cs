using ConsistencySampleLibrary.Data;
using ConsistencySampleLibrary.Interfaces;
using ConsistencySampleLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using ConsistencySampleLibrary.Extensions;
#pragma warning disable CS8603 // Possible null reference return.

namespace ConsistencySampleLibrary.Repositories;

public class ProductsRepository : IGenericRepository<Product>, IDisposable
{
    private Context _context;

    public ProductsRepository(Context context)
    {
        _context = context;
    }

    public IEnumerable<Product> GetAll()
    {
        return _context.Products.ToList();
    }

    public Task<List<Product>> GetAllAsync()
    {
        return _context.Products.ToListAsync();
    }

    public Product GetById(int id)
    {
        return _context.Products.Find(id);
    }

    public Product GetByIdWithIncludes(int id)
    {
        return _context.Products
            .Include(x => x.Category)
            .FirstOrDefault(x => x.ProductId == id);
    }

    public async Task<Product> GetByIdAsync(int id)
    {
        return await _context.Products.FindAsync(id);
    }

    public async Task<Product> GetByIdWithIncludesAsync(int id)
    {
        return await _context
            .Products
            .Include(x => x.Category)
            .FirstOrDefaultAsync(x => x.ProductId == id);
    }

    public bool Remove(int id)
    {
        var product = _context.Products.Find(id);
        if (product is { })
        {
            _context.Products.Remove(product);
            return true;
        }

        return false;
    }

    public void Add(in Product sender)
    {
        _context.Add(sender).State = EntityState.Added;
    }

    public void Update(in Product sender)
    {
        _context.Entry(sender).State = EntityState.Modified;
    }

    public int Save()
    {
        return _context.SaveChanges();
    }

    public Task<int> SaveAsync()
    {
        return _context.SaveChangesAsync();
    }

    public Product Select(Expression<Func<Product, bool>> predicate) 
        => _context.Products
            .WhereNullSafe(predicate)
            .FirstOrDefault()!;

    public async Task<Product> SelectAsync(Expression<Func<Product, bool>> predicate) 
        => 
        (
            await _context
                .Products
                .WhereNullSafe(predicate)
                .FirstOrDefaultAsync()
        )!;

    private bool _disposed = false;

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
        _disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}