using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Serilog;

namespace RadioButtonsApp.Pages;
public class IndexModel : PageModel
{
    public void OnGet()
    {

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
