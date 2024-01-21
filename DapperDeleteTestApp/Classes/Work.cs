using System.Data;
using Dapper;
using DapperDeleteTestApp.Models;
using Microsoft.Data.SqlClient;

namespace DapperDeleteTestApp.Classes;
internal class Work
{
    private IDbConnection _cn = new SqlConnection(ConnectionString());

    /// <summary>
    /// If the backup table exists delete the table
    /// </summary>
    public void DropBackupProductTable()
    {
        _cn.Execute("DROP TABLE IF EXISTS [dbo].ProductBackup;");
    }
    /// <summary>
    /// Create a backup of the product table
    /// </summary>
    public void CreateBackupOfProductTable()
    {
        PrintCyan();
        _cn.Execute("SELECT Id, ProductName, Category,Price INTO dbo.ProductBackup FROM dbo.Product;");
    }
    /// <summary>
    /// Delete some records from the product table
    /// </summary>
    public void DeleteSomeRecordsFromProductTable()
    {
        PrintCyan();
        int[] keys = [1, 3, 5, 7];
        _cn.Execute("DELETE FROM dbo.Product WHERE id IN @keys;", new { keys = keys });
        AnsiConsole.MarkupLine("[yellow]Removed records 1,3,5,7[/]");
        ShowData();
    }
    /// <summary>
    /// 1. Delete all records from product table
    /// 2. Reset identity so that when inserting the id starts with 1
    /// </summary>
    public void DeleteAllRecordsFromProductTable()
    {
        PrintCyan();
        _cn.Execute("DELETE FROM dbo.product;");
        _cn.Execute("DBCC CHECKIDENT ('product', RESEED, 0);");
        ShowData();
    }
    /// <summary>
    /// Populate product table from backup table
    /// </summary>
    public void CopyFromBackupToOriginalProductTable()
    {
        PrintCyan();
        _cn.Execute("INSERT INTO dbo.product (ProductName, Category,Price) SELECT ProductName, Category,Price FROM dbo.ProductBackup");
        ShowData();
    }
    public void ShowData()
    {
        PrintCyan();
        var list = _cn.Query<Product>("SELECT Id,ProductName,Category,Price FROM dbo.Product");
        AnsiConsole.MarkupLine(list.Any() ?
            $"[pink1]{string.Join(",", list.Select(x => x.Id))}[/]" :
            "[red]No records[/]");
    }
}