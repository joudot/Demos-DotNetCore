using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.Interfaces
{
    public interface IAzureStorageService
    {
        void SaveCar(Car car);

        Car GetCar(string name);
    }
}
