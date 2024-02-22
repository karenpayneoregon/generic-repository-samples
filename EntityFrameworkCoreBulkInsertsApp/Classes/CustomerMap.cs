using System.Globalization;
using CsvHelper.Configuration;
using EntityFrameworkCoreBulkInsertsApp.Models;

namespace EntityFrameworkCoreBulkInsertsApp.Classes;

public sealed class CustomerMap : ClassMap<Customer>
{
    public CustomerMap()
    {
        AutoMap(CultureInfo.InvariantCulture);
        Map(m => m.Id).Ignore();
    }
}