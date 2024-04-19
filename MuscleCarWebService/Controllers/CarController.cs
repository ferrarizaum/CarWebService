using Microsoft.AspNetCore.Mvc;
using MuscleCarWebService.Models;

namespace MuscleCarWebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        private static readonly Car[] Cars = new Car[]
        {
            new Car { Model = "Mustang", Year = "1964", Maker = "Ford", Summary = "Classic muscle car" },
            new Car { Model = "Opala", Year = "1969", Maker = "Chevrolet", Summary = "Classic muscle car" },
            new Car { Model = "Charger", Year = "1966", Maker = "Dodge", Summary = "Classic muscle car" },
        };

        private readonly ILogger<CarController> _logger;

        public CarController(ILogger<CarController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetCar")]
        public IEnumerable<Car> Get()
        {
            return Cars.ToArray();
            
        }
    }
}
