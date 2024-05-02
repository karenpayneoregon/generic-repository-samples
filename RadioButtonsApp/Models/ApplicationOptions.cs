namespace RadioButtonsApp.Models;

    public class ApplicationOptions
    {
        public const string Settings = "AppSettings";
        public string Name { get; set; } = string.Empty;
        public string DefaultConnection { get; set; } = string.Empty;
    }