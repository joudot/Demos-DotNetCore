using System;
using System.Collections.Generic;
using System.Linq;
using DependencyInjectionDemo.Controllers;
using DependencyInjectionDemo.Services;
using Xunit;

namespace DependencyInjectionDemoTest
{
    public class CarsControllerTest
    {
        [Fact]
        public void TestPost()
        {
            CarsController controller = new CarsController(new BusinessLogicService(), new MockAzureStorageService());

            var result = controller.Post(new List<string> { "car1", "" });
            Assert.False(result.Any());

            result = controller.Post(new List<string> { "car1", "car2" });
            Assert.Equal("CAR1", result[0]);
            Assert.Equal("CAR2", result[1]);
        }
    }
}
