using System.Collections;
using System.Diagnostics;
using CsvHelper;
using EntityFrameworkCoreBulkInsertsApp.Classes;
using System.Globalization;
using EFCore.BulkExtensions;
using EntityFrameworkCoreBulkInsertsApp.Data;
using EntityFrameworkCoreBulkInsertsApp.Models;

namespace EntityFrameworkCoreBulkInsertsApp;

public partial class Form1 : Form
{
    private string delimitedFileName => "Customers.csv";
    public Form1()
    {
        InitializeComponent();
    }

    private void BogusCreateFileButton_Click(object sender, EventArgs e)
    {

        List<Customer> customersList = BogusOperations.CreateCustomers(500_000);

        FileOperations.WriteCustomersToFile(customersList, delimitedFileName);
        MessageBox.Show("Done");
    }

    private List<Customer> _customers;
    private void ReadDelimitedFileButton_Click(object sender, EventArgs e)
    {
        _customers = FileOperations.ReadCustomers(delimitedFileName);
        MessageBox.Show("Done");
    }

    private void SaveToDatabaseButton_Click(object sender, EventArgs e)
    {
        if (_customers is not null)
        {
            EntityFrameworkOperations operations = new();

            Stopwatch stopwatch = new();
            stopwatch.Start();

            operations.Work(_customers);
            stopwatch.Stop();

            TimeSpan timeSpan = stopwatch.Elapsed;

            MessageBox.Show($"Hours {timeSpan.Hours} Minutes {timeSpan.Minutes} Seconds: {timeSpan.Seconds}");

            using var context = new Context();
            var list = context.Customer.Take(20).ToList();
            dataGridView1.DataSource = list;
        }
        else
        {
            MessageBox.Show("Must populate first...");
        }

    }

    private void SaveToDatabaseButton2_Click(object sender, EventArgs e)
    {
        if (_customers is not null)
        {


            Stopwatch stopwatch = new();
            stopwatch.Start();

            using var context1 = new Context();
            // https://github.com/borisdj/EFCore.BulkExtensions
            var bulkConfig = new BulkConfig { BatchSize = 4000 };
            context1.BulkInsert(_customers);

            stopwatch.Stop();

            TimeSpan timeSpan = stopwatch.Elapsed;

            MessageBox.Show($"Hours {timeSpan.Hours} Minutes {timeSpan.Minutes} Seconds: {timeSpan.Seconds}");

            using var context = new Context();
            var list = context.Customer.Take(20).ToList();
            dataGridView1.DataSource = list;
        }
        else
        {
            MessageBox.Show("Must populate first...");
        }
    }

    private void SampleButton_Click(object sender, EventArgs e)
    {
        using var context = new Context();
        var customer = context.Customer.FirstOrDefault();
    }

    private void ResetCustomerTableButton_Click(object sender, EventArgs e)
    {
        DapperOperations operations = new();
        operations.Reset();
        MessageBox.Show("Done");
    }
}
