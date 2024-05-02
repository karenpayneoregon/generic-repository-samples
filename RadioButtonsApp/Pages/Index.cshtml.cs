using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using RadioButtonsApp.Classes;
using RadioButtonsApp.Models;
using Serilog;

/*
 * https://learn.microsoft.com/en-us/aspnet/core/release-notes/aspnetcore-8.0?view=aspnetcore-8.0#keyed-services-support-in-dependency-injection
 * https://andrewlock.net/exploring-the-dotnet-8-preview-keyed-services-dependency-injection-support/
 * https://code-maze.com/csharp-using-keyed-services-to-resolve-dependencies/
 * https://stackoverflow.com/a/77007913/5509738
 *
 */

namespace RadioButtonsApp.Pages;
public class IndexModel : PageModel
{
    private readonly IConfiguration _configuration;

    private readonly ApplicationOptions _applicationSettings;

    [BindProperty]
    public string ConnectionString { get; set; }

    public IndexModel(IOptionsSnapshot<ApplicationOptions> applicationSettings, IConfiguration configuration)
    {
        _applicationSettings = applicationSettings.Value;
        ConnectionString = _applicationSettings.DefaultConnection;
        _configuration = configuration;
    }

    public void OnGet([FromKeyedServices("dapper")] IDataService service)
    {
        Log.Information(service.Get("contacts", _applicationSettings));
    }


    [BindProperty]
    public string? UserResponse { get; set; }

    public string[] Answers = { "Yes", "No"};
    public async Task<IActionResult> OnPost()
    {
        await Task.Delay(0);
        var selection = UserResponse;
        if (string.IsNullOrEmpty(selection))
        {
            Log.Information("No selection");
        }
        else
        {

            Log.Information("Choice is {C1}", selection.ToLower() == "yes");
        }

        return Page();
    }
}
