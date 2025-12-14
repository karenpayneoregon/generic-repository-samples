using ConsistencySampleLibrary.Interfaces;

namespace ConsistencySampleLibrary.Models;

/// <summary>
/// Represents a product entity with properties for identification, name, and category.
/// </summary>
/// <remarks>
/// This class implements the <see cref="Interfaces.IBase"/> interface 
/// and provides additional properties specific to products, such as <c>ProductId</c>, <c>Name</c>, 
/// and <c>Category</c>.
/// </remarks>
public class Product : IBase
{
    public int Id => ProductId;
    public int ProductId { get; set; }
    public string? Name { get; set; }
    public int CategoryId { get; set; }
    public virtual Category Category { get; set; } = null!;
    public override string? ToString() => Name;
}
