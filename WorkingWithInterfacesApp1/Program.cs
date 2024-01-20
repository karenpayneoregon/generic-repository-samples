using ConsistencySampleLibrary.Data;
using ConsistencySampleLibrary.Interfaces;
using ConsistencySampleLibrary.Models;
using ConsistencySampleLibrary.Repositories;
using GeneralExtensionsLibrary;
using WorkingWithInterfacesApp1.Classes;

namespace WorkingWithInterfacesApp1;

internal partial class Program
{
    static async Task Main(string[] args)
    {
        await CreateAndPopulateDatabase();
        await ProductsExample();
        SpectreConsoleHelpers.ExitPrompt();
    }

    /// <summary>
    /// Demonstrates using <see cref="IGenericRepository{T}"/>
    /// </summary>
    private static async Task ProductsExample()
    {
        await using Context context = new ();
        var productsRepository = new ProductsRepository(context);
        var countryRepository = new CountryRepository(context);

        var allProducts = productsRepository.GetAll().ToList();

        var firstProduct = await productsRepository.GetByIdWithIncludesAsync(1);
        AnsiConsole.MarkupLine($"[white]First product[/] [cyan]{firstProduct.Name}[/] [white]and category[/] [cyan]{firstProduct.Category.Name}[/]");

        var one = await productsRepository.GetByIdAsync(4);
        var deleted = productsRepository.Remove(4);
        AnsiConsole.MarkupLine($"[red]Deleted[/] {deleted.ToYesNo()}");

        var newProduct = new Product { CategoryId = 4, Name = "Test2" };
        productsRepository.Add(newProduct);

        
        /*
         * We have an add and a removal so expect save changes will be 2
         */
        AnsiConsole.MarkupLine($"[cyan]Saved {(await productsRepository.SaveAsync() == 2).ToYesNo()}[/]");

        var editProduct = await productsRepository.GetByIdAsync(newProduct.ProductId);
        editProduct.Name = "Karen changed";
        AnsiConsole.MarkupLine($"[cyan]Saved {(await productsRepository.SaveAsync() == 1).ToYesNo()}[/]");

        Console.WriteLine();
        AnsiConsole.MarkupLine("[white on blue]Working with IBase[/]");

        List<IBase> bases = new();
        bases.AddRange(productsRepository.GetAll().ToList());
        bases.AddRange(await countryRepository.GetAllAsync());

        foreach (var item in bases)
        {
            if (item is Countries c)
            {
                Console.WriteLine($"{c.Id, -4}{c.Name}");
            }
        }

        Console.WriteLine();
    }


}