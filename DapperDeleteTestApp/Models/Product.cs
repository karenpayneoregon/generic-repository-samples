namespace DapperDeleteTestApp.Models;

public class Product
{
    public int Id { get; set; }
    public string ProductName { get; set; }
    public string Category { get; set; }
    public decimal? Price { get; set; }
    public override string ToString() => ProductName;

}