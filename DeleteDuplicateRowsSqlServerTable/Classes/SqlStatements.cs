namespace DeleteDuplicateRowsSqlServerTable.Classes;
internal class SqlStatements
{
    // Karen @KarenPayneMVP
    public static string Statement1 => 
        """
        DELETE FROM dbo.PersonWithDuplicates 
        WHERE Id IN (
            SELECT Id FROM dbo.PersonWithDuplicates 
            EXCEPT SELECT MIN(Id) FROM dbo.PersonWithDuplicates 
            GROUP BY FirstName, LastName
            );
        """;

    // João Silva @kappyzor
    public static string Statement2 =>
        """
        DELETE t
        FROM dbo.PersonWithDuplicates t
            INNER JOIN
            (
                SELECT MIN(Id) min_id,
                       FirstName,
                       LastName,
                       BirthDay,
                       SUM(1) AS dup_count
                FROM dbo.PersonWithDuplicates
                GROUP BY FirstName,
                         LastName,
                         BirthDay
            ) dups
                ON (
                       t.FirstName = dups.FirstName
                       AND t.LastName = dups.LastName
                       AND t.BirthDay = dups.BirthDay
                   )
        WHERE dup_count > 1
              AND t.Id <> min_id;
        """;
    
    public static string CreatePopulateTableGetDuplicates =>
        """
        DECLARE @TempTable TABLE (id INT,name VARCHAR(10),email VARCHAR(50));
        
        INSERT @TempTable VALUES (1, 'John', 'John-email');
        INSERT @TempTable VALUES (2, 'John', 'John-email');
        INSERT @TempTable VALUES (3, 'Fred', 'John-email');
        INSERT @TempTable VALUES (4, 'Fred', 'fred-email');
        INSERT @TempTable VALUES (5, 'Sam', 'sam-email');
        INSERT @TempTable VALUES (6, 'Sam', 'sam-email');    
        
        SELECT y.id, y.name, y.email FROM @TempTable y
            INNER JOIN
            (
                SELECT name,email,COUNT(*) AS CountOf FROM @TempTable
                GROUP BY name,email HAVING COUNT(*) > 1
            ) dt ON y.name = dt.name AND y.email = dt.email;                   
        """;
}
