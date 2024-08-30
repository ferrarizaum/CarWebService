using Microsoft.AspNetCore.Mvc;
using CarWebService.Models;
using CarWebService.Services;

namespace CarWebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        private readonly ILogger<CarController> _logger;
        private readonly CarService _carService;

        public CarController(ILogger<CarController> logger, CarService carService)
        {
            _carService = carService;
            _logger = logger;
        }

        [HttpGet(Name = "GetCar")]
        public List<Car> Get()
        {
            return _carService.GetCars();
        }

        [HttpPost(Name = "PostCar")]
        public void Post(string model, string year, string maker, string summary, string category)
        {
            Car newCar = new Car { Model = model, Year = year, Maker = maker, Summary = summary, Category = category };
            _carService.AddCar(newCar);
        }

        [HttpPut(Name = "UpdateCar")]
        public void Update(string model, string newName)
        {
            _carService.UpdateCar(model, newName);
        }

        [HttpDelete(Name = "DeleteCar")]
        public void Delete(string model)
        {
            _carService.DeleteCar(model);
        }
    }
}
