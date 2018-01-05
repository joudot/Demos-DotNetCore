using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjectionDemo.Interfaces;

namespace DependencyInjectionDemo.Services
{
    public class BusinessLogicService : IBusinessLogicService
    {
        public bool CreateCarsAndValidate(List<string> carNames, out List<Car> cars)
        {
            cars = new List<Car>();
            if (!carNames.Any() || carNames.Any(string.IsNullOrEmpty))
                return false;

            foreach (var carName in carNames)
            {
                cars.Add(new Car { Name = carName.ToUpper() });
            }
            return true;
        }
    }
}
