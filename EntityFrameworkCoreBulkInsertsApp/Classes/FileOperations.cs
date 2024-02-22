using System.Collections;
using System.Globalization;
using CsvHelper;
using EntityFrameworkCoreBulkInsertsApp.Models;

namespace EntityFrameworkCoreBulkInsertsApp.Classes;

public class FileOperations
{

    /// <summary>
    /// Write list of Customer to a comma delimited file
    /// </summary>
    /// <param name="customersList"></param>
    /// <param name="delimitedFileName"></param>
    public static void WriteCustomersToFile(List<Customer> customersList, string delimitedFileName)
    {
 
        using var writer = new StreamWriter(delimitedFileName);
        using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);

        csv.WriteRecords((IEnumerable)customersList);
    }

    /// <summary>
    /// Read delimited file to a list of Customer
    /// </summary>
    /// <param name="delimitedFileName">comma delimited file of customers</param>
    /// <returns></returns>
    public static List<Customer> ReadCustomers(string delimitedFileName)
    {
        using var reader = new StreamReader(delimitedFileName);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        csv.Context.RegisterClassMap<CustomerMap>();

        List<Customer> records = csv.GetRecords<Customer>().ToList();
        return records;
    }
}