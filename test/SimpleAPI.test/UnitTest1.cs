using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();


        [Fact]
        public void GetReturnsMyName()
        {
            var retturnValue = controller.Get(1);
            Assert.Equal("Hola mun", retturnValue.Value);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
