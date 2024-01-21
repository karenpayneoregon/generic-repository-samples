using DapperDeleteTestApp.Classes;

namespace DapperDeleteTestApp;

internal partial class Program
{
    static void Main(string[] args)
    {
        var work = new Work();
        work.DropBackupProductTable();
        work.CreateBackupOfProductTable();
        work.DeleteSomeRecordsFromProductTable();
        work.DeleteAllRecordsFromProductTable();
        work.CopyFromBackupToOriginalProductTable();
        work.DropBackupProductTable();
        AnsiConsole.MarkupLine("[yellow]Done[/]");
        Console.ReadLine();
    }
}