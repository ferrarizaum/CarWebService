using Microsoft.AspNetCore.Mvc;
using CarWebService.Models;

namespace CarWebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {      
        private readonly ILogger<CarController> _logger;
        private readonly CarList _carList;

        public CarController(ILogger<CarController> logger, CarList carList)
        {
            _carList = carList;
            _logger = logger;
        }

        [HttpGet(Name = "GetCar")]
        public List<Car> Get()
        {
            return _carList.Cars.ToList();
        }

        [HttpPost(Name = "PostCar")]
        public void Post(string model, string year, string maker, string summary)
        {
            Car newCar = new Car { Model =  model, Year = year, Maker = maker, Summary = summary };
            _carList.Cars.Add(newCar);
        }
    }
}
