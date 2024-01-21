using Microsoft.Data.SqlClient;
using System.Data;
using Dapper;
using NumberToDateInSqlServer.Models;
using kp.Dapper.Handlers;

namespace NumberToDateInSqlServer;

internal partial class Program
{
    static void Main(string[] args)
    {
        Operations operations = new Operations();
        List<ChallengeTable> data = operations.GetAll();
        Console.WriteLine(ObjectDumper.Dump(data));
        Console.ReadLine();
    }
}

/// <summary>
/// Belongs in its own file but for this it is easier to work with.
/// </summary>
internal class Operations
{
    private IDbConnection _cn;

    public Operations()
    {
        SqlMapper.AddTypeHandler(new SqlDateOnlyTypeHandler());
        _cn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Examples;Integrated Security=True;Encrypt=False");
    }
    public List<ChallengeTable> GetAll()
        => _cn.Query<ChallengeTable>(
            """
            SELECT Id,DateValue TODO FROM Examples.dbo.ChallengeTable;
            """).ToList();
}