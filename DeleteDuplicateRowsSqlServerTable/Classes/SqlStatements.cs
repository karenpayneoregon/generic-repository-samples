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
}
