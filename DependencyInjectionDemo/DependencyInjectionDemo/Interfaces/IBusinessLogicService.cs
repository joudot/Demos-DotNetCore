using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.Interfaces
{
    public interface IBusinessLogicService
    {
        bool CreateCarsAndValidate(List<string> carNames, out List<Car> cars);
    }
}
