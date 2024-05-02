using RadioButtonsApp.Models;
using Serilog;
using Serilog.Events;
using SeriLogThemesLibrary;

namespace RadioButtonsApp.Classes;
/// <summary>
/// For setting up SeriLog to keep Program.Main clean and allows code to be easily copied to other projects.
/// </summary>
public class SetupLogging
{
    /// <summary>
    /// Configure SeriLog
    /// </summary>
    public static void Development()
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
            .WriteTo.Console(theme: SeriLogCustomThemes.Default())
            .CreateLogger();
    }
}


    public interface IDataService
    {
        string Get(string key, ApplicationOptions options);
    }
    public class EntityCore : IDataService
    {
        public string Get(string key, ApplicationOptions options)
        {
            return $"Key {key} EF Core";
        }
    }

    public class Dapper : IDataService
    {
        public string Get(string key, ApplicationOptions options)
        {
            return $"Key {key} Dapper";
        }
    }