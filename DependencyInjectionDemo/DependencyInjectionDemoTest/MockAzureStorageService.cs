using System;
using System.Collections.Generic;
using System.Text;
using DependencyInjectionDemo.Interfaces;

namespace DependencyInjectionDemoTest
{
    class MockAzureStorageService : IAzureStorageService
    {
        private readonly IDictionary<string, Car> cars;

        public MockAzureStorageService()
        {
            cars = new Dictionary<string, Car>();
        }

        public void SaveCar(Car car)
        {
            cars[car.Name] = car;
        }

        public Car GetCar(string name)
        {
            return cars[name];
        }
    }
}
