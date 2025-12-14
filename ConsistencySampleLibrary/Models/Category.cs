using ConsistencySampleLibrary.Interfaces;

namespace ConsistencySampleLibrary.Models;

/// <summary>
/// Represents a category entity with properties for identification, name, and associated products.
/// </summary>
/// <remarks>
/// This class implements the <see cref="Interfaces.IBase"/> interface and provides additional properties 
/// specific to categories, such as <c>CategoryId</c>, <c>Name</c>, and a collection of <c>Products</c>.
/// It is used to categorize products within the application.
/// </remarks>
public class Category : IBase
{
    public int Id => CategoryId;
    public int CategoryId { get; set; }
    public string? Name { get; set; }
    public virtual ICollection<Product>? Products { get; set; }
    public override string? ToString() => Name;
}
