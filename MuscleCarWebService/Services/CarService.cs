using CarWebService.Models;

namespace CarWebService.Services
{
    public class CarService
    {
        private readonly CarList _carList;
        public CarService(CarList carList)
        {
            _carList = carList ?? throw new ArgumentNullException(nameof(carList));
        }

        public List<Car> GetCars()
        {
            return _carList.Cars.ToList();
        }
        public Car AddCar(Car newCar)
        {
            _carList.Cars.Add(newCar);

            return newCar;
        }
        public Car UpdateCar(string model, string newName)
        {
            Car selectedCar = _carList.Cars.Find(x => x.Model == model);
            if (selectedCar != null)
            {
                selectedCar.Model = newName;

                return selectedCar;
            }

            throw new KeyNotFoundException($"Car with model '{model}' not found.");
        }

        public Car DeleteCar(string model)
        {
            Car selectedCar = _carList.Cars.Find(x => x.Model == model);
            if (selectedCar != null)
            {
                _carList.Cars.Remove(selectedCar);
                return selectedCar;
            }

            throw new KeyNotFoundException($"Car with model '{model}' not found.");
        }
    }
}
