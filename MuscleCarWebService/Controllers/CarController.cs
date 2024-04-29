using Microsoft.AspNetCore.Mvc;
using CarWebService.Models;

namespace CarWebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {      
        private readonly ILogger<CarController> _logger; //what is this ?
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

        [HttpDelete(Name = "DeleteCar")]
        public void Delete(string model)
        {
            Car selectedCar = _carList.Cars.Find(x => x.Model == model);
            _carList.Cars.Remove(selectedCar);
        }

        [HttpPut(Name = "UpdateCar")]
        public void Update(string model, string newName)
        {
            Car selectedCar = _carList.Cars.Find(x => x.Model == model);
            selectedCar.Model = newName;
        }
    }
}
