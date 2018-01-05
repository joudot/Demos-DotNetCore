using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjectionDemo.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionDemo.Controllers
{
    [Route("api/[controller]")]
    public class CarsController : Controller
    {
        private readonly IBusinessLogicService _businessLogic;

        private readonly IAzureStorageService _azureStorageService;

        public CarsController(IBusinessLogicService businessLogicService,
            IAzureStorageService azureStorageService)
        {
            _businessLogic = businessLogicService;
            _azureStorageService = azureStorageService;
        }

        // POST api/cars
        [HttpPost]
        public List<string> Post([FromBody] List<string> carNames)
        {
            if (_businessLogic.CreateCarsAndValidate(carNames, out List<Car> cars))
            {
                foreach (var car in cars)
                {
                    _azureStorageService.SaveCar(car);
                }
                return cars.Select(c => c.Name).ToList();
            }
            return new List<string>();
        }
    }
}
