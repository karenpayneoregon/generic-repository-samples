using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using EntityFrameworkCoreBulkInsertsApp.Models;
using static ConfigurationLibrary.Classes.ConfigurationHelper;

namespace EntityFrameworkCoreBulkInsertsApp.Classes;
internal class DapperOperations
{
    private IDbConnection _cn = new SqlConnection(ConnectionString());

    /// <summary>
    /// Reset table Customer and reset identity.
    /// </summary>
    public void Reset()
    {
        _cn.Execute($"DELETE FROM dbo.{nameof(Customer)}");
        _cn.Execute($"DBCC CHECKIDENT ({nameof(Customer)}, RESEED, 0)");
    }
}
