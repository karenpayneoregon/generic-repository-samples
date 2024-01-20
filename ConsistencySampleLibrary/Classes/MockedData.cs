using ConsistencySampleLibrary.Models;

namespace ConsistencySampleLibrary.Classes;

/// <summary>
/// Responsible for populating tables for EF Core
/// </summary>
public class MockedData
{
    public static List<Category> Categories() =>
    [
        new() { CategoryId = 1, Name = "Cheese" },
        new() { CategoryId = 2, Name = "Meat" },
        new() { CategoryId = 3, Name = "Fish" },
        new() { CategoryId = 4, Name = "Bread" }
    ];

    public static List<Countries> Countries() =>
    [
        new() { CountryId = 1, Name = "Argentina" },
        new() { CountryId = 2, Name = "Austria" },
        new() { CountryId = 3, Name = "Belgium" },
        new() { CountryId = 4, Name = "Brazil" },
        new() { CountryId = 5, Name = "Canada" },
        new() { CountryId = 6, Name = "Denmark" },
        new() { CountryId = 7, Name = "France" },
        new() { CountryId = 8, Name = "Germany" },
        new() { CountryId = 9, Name = "Ireland" },
        new() { CountryId = 10, Name = "Italy" }
    ];

    public static List<Product> Products()
    {
        return
        [
            new() { ProductId = 1, CategoryId = 1, Name = "Cheddar" },
            new() { ProductId = 2, CategoryId = 1, Name = "Brie" },
            new() { ProductId = 3, CategoryId = 1, Name = "Stilton" },
            new() { ProductId = 4, CategoryId = 1, Name = "Cheshire" },
            new() { ProductId = 5, CategoryId = 1, Name = "Swiss" },
            new() { ProductId = 6, CategoryId = 1, Name = "Gruyere" },
            new() { ProductId = 7, CategoryId = 1, Name = "Colby" },
            new() { ProductId = 8, CategoryId = 1, Name = "Mozzela" },
            new() { ProductId = 9, CategoryId = 1, Name = "Ricotta" },
            new() { ProductId = 10, CategoryId = 1, Name = "Parmesan" },
            new() { ProductId = 11, CategoryId = 2, Name = "Ham" },
            new() { ProductId = 12, CategoryId = 2, Name = "Beef" },
            new() { ProductId = 13, CategoryId = 2, Name = "Chicken" },
            new() { ProductId = 14, CategoryId = 2, Name = "Turkey" },
            new() { ProductId = 15, CategoryId = 2, Name = "Prosciutto" },
            new() { ProductId = 16, CategoryId = 2, Name = "Bacon" },
            new() { ProductId = 17, CategoryId = 2, Name = "Mutton" },
            new() { ProductId = 18, CategoryId = 2, Name = "Pastrami" },
            new() { ProductId = 19, CategoryId = 2, Name = "Hazlet" },
            new() { ProductId = 20, CategoryId = 2, Name = "Salami" },
            new() { ProductId = 21, CategoryId = 3, Name = "Salmon" },
            new() { ProductId = 22, CategoryId = 3, Name = "Tuna" },
            new() { ProductId = 23, CategoryId = 3, Name = "Mackerel" },
            new() { ProductId = 24, CategoryId = 4, Name = "Rye" },
            new() { ProductId = 25, CategoryId = 4, Name = "Wheat" },
            new() { ProductId = 26, CategoryId = 4, Name = "Brioche" },
            new() { ProductId = 27, CategoryId = 4, Name = "Naan" },
            new() { ProductId = 28, CategoryId = 4, Name = "Focaccia" },
            new() { ProductId = 29, CategoryId = 4, Name = "Malted" },
            new() { ProductId = 30, CategoryId = 4, Name = "Sourdough" },
            new() { ProductId = 31, CategoryId = 4, Name = "Corn" },
            new() { ProductId = 32, CategoryId = 4, Name = "White" },
            new() { ProductId = 33, CategoryId = 4, Name = "Soda" }
        ];
    }
}