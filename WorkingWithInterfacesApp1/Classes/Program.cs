


using ConsistencySampleLibrary.Data;
// ReSharper disable once CheckNamespace
using System.Runtime.CompilerServices;
using static WorkingWithInterfacesApp1.Classes.SpectreConsoleHelpers;

namespace WorkingWithInterfacesApp1;
internal partial class Program
{
    [ModuleInitializer]
    public static void Init()
    {
        AnsiConsole.MarkupLine("");
        Console.Title = "Code sample";
        WindowUtility.SetConsoleWindowPosition(WindowUtility.AnchorWindow.Center);
    }
    private static async Task CreateAndPopulateDatabase()
    {
        PrintCyan();
        await using var context = new Context();
        await context.Database.EnsureDeletedAsync();
        await context.Database.EnsureCreatedAsync();
        AnsiConsole.MarkupLine("[cyan]Database created[/]");
    }   
}
