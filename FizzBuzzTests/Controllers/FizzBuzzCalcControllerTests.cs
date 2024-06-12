using FizzBuzzWebApp.Server.Controllers;
using FizzBuzzWebApp.Server.Interfaces;
using Microsoft.Extensions.Logging;
using FizzBuzzWebApp.Server.Models;
using Moq;

namespace FizzBuzzTests.Controllers
{
    public class FizzBuzzCalcControllerTests
    {
        private Mock<ILogger<FizzBuzzCalcController>> _mockLogger;
        private Mock<IFizzBuzzCalcService> _mockService;

        public FizzBuzzCalcControllerTests() {
            _mockLogger = new();
            _mockService = new();
        }
        [Fact]
        public void FizzBuzzCalcController_GetFizzBuzz_Returns200OK()
        {
            //arrange
            FizzBuzzResponse response = new();
            response.FizzBuzzValue = "FizzBuzz";
            string input = "15";
            _mockService.Setup(x => x.RunCalculation(input)).Returns(response);
            FizzBuzzCalcController controller = new(_mockLogger.Object, _mockService.Object);

            //act
            var actual = controller.GetFizzBuzz(input);

            //assert
            Assert.Equal(actual, response);
        }
    }
}
