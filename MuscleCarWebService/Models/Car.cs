namespace CarWebService.Models
{
    public class Car
    {
        public string Model { get; set; }
        public string Year { get; set; }
        public string Maker { get; set; }
        public string? Summary { get; set; }
        public string? Category { get; set; }
    }
}