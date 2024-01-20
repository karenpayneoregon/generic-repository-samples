using ConsistencySampleLibrary.Classes;
using ConsistencySampleLibrary.Models;
using EntityCoreUtilityLibrary;
using Microsoft.EntityFrameworkCore;


using Spectre.Console;
using static ConfigurationLibrary.Classes.ConfigurationHelper;
using static ConfigurationLibrary.Classes.ConnectionsConfiguration;
using static Microsoft.Extensions.Logging.LogLevel;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace ConsistencySampleLibrary.Data;

public class Context : DbContext
{

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Countries> Countries { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            /*
             * Indicate the provider and connection string, log to LogFiles under the calling application
             * A log file is generated one per day
             */
            optionsBuilder.UseSqlServer(ConnectionString()).LogTo(new DbContextToFileLogger().Log,
                new[] { DbLoggerCategory.Database.Command.Name }, Information);
        }
    }

    public Context()
    {
    }
    public Context(DbContextOptions<Context> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        /*
         * For demonstration only and will show up twice
         * As coded will never run unless in development environment,
         * this would need to change for web applications as the check below is not for web.
         */
        if (CurrentEnvironment == Development)
        {
            AnsiConsole.MarkupLine("[yellow]Populating tables[/]");
            modelBuilder.Entity<Category>().HasData(MockedData.Categories());
            modelBuilder.Entity<Countries>().HasData(MockedData.Countries());
            modelBuilder.Entity<Product>().HasData(MockedData.Products());
        }

    }
}
