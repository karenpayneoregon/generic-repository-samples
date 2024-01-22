using System.Data;
using Dapper;
using DeleteDuplicateRowsSqlServerTable.Models;
using kp.Dapper.Handlers;
using Microsoft.Data.SqlClient;

namespace DeleteDuplicateRowsSqlServerTable.Classes;

/// <summary>
/// Belongs in its own file but for this it is easier to work with.
/// </summary>
internal class Operations
{
    private IDbConnection _cn;

    /// <summary>
    /// Setup for Dapper to work with DateOnly
    /// Create a connection to the database
    /// </summary>
    /// <remarks>
    /// If not using SQLEXPRESS change it here to your server
    /// </remarks>
    public Operations()
    {
        SqlMapper.AddTypeHandler(new SqlDateOnlyTypeHandler());
        _cn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Examples;Integrated Security=True;Encrypt=False");
    }

    /// <summary>
    /// Read current data
    /// </summary>
    public List<PersonWithDuplicates> GetAll()
        => _cn.Query<PersonWithDuplicates>(
            """
            SELECT Id, FirstName, LastName, BirthDay FROM Examples.dbo.PersonWithDuplicates;
            """).ToList();

    /// <summary>
    /// Flush current rows, reset identity, repopulate data
    /// </summary>
    public void Populate()
    {
        Reset();
        _cn.Execute(
            """
            INSERT INTO PersonWithDuplicates ([FirstName], [LastName], [BirthDay])
            VALUES
            (N'Bill', N'Smith', N'1976-09-01' ),
            (N'Mary', N'Robinson', N'1945-12-12' ),
            (N'Bill', N'Smith', N'1976-09-01' ),
            (N'Bill', N'Smith', N'1976-09-01' ),
            (N'Nancy', N'Jones', N'2000-02-23' ),
            (N'Nancy', N'Johnson', N'2005-08-12' ),
            (N'Nancy', N'Jones', N'2000-02-23' ),
            (N'Karen', N'Payne', N'1956-09-09' ),
            (N'Kim', N'Adams', N'1989-07-12' ),
            (N'Karen', N'Payne', N'1956-09-09' )
            """);
    }

    /// <summary>
    /// Reset table
    /// </summary>
    public void Reset()
    {
        _cn.Execute($"DELETE FROM dbo.{nameof(PersonWithDuplicates)}");
        _cn.Execute($"DBCC CHECKIDENT ({nameof(PersonWithDuplicates)}, RESEED, 0)");
    }

    /// <summary>
    /// Remove duplicates
    /// </summary>
    public void RemoveDuplicates()
    {
        _cn.Execute(
            """
            TODO
            """);
    }

}