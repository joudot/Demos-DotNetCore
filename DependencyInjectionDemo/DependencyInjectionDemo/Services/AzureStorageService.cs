using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjectionDemo.Interfaces;

namespace DependencyInjectionDemo.Services
{
    public class AzureStorageService : IAzureStorageService
    {
        public void SaveCar(Car car)
        {
            // DB calls reyling on Azure storage in the Cloud OR...
            throw new NotImplementedException();
        }

        public Car GetCar(string name)
        {
            // DB calls reyling on Azure storage in the Cloud OR...

            throw new NotImplementedException();
        }
    }
}
