using Microsoft.AspNetCore.Mvc;

namespace MuscleCarWebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        private static readonly string[] Cars = new[]
        {
            "Mustang", "Camaro", "Charger", "Challenger", "Impala", "Roadrunner", "Opala", "Maverick", "Dart", "Cougar"
        };

        private readonly ILogger<CarController> _logger;

        public CarController(ILogger<CarController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetCar")]
        public IEnumerable<string> Get()
        {
            return Cars.ToArray();
            
        }
    }
}
