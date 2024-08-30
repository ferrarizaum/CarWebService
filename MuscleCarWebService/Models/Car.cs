namespace CarWebService.Models
{
    public class Car
    {
        public string Model { get; set; } = string.Empty;
        public string Year { get; set; } = string.Empty;
        public string Maker { get; set; } = string.Empty;
        public string? Summary { get; set; }
        public string? Category { get; set; }
    }
}