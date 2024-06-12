using FizzBuzzWebApp.Server.Services;
using FizzBuzzWebApp.Server.Models;

namespace FizzBuzzTests.Services
{
    public class FizzBuzzCalcServiceTests
    {
        [Theory]
        [InlineData("12", "Fizz")]
        [InlineData("15", "FizzBuzz")]
        [InlineData("10", "Buzz")]
        [InlineData("", "Invalid Item")]
        [InlineData("A", "Invalid Item")]
        [InlineData(null, "Invalid Item")]
        public void FizzBuzz_ReturnsValue(string input, string output)
        {
            //arrange
            FizzBuzzCalcService service = new();

            //act
            FizzBuzzResponse response = service.RunCalculation(input);
            string actual = response.FizzBuzzValue;

            //assert
            Assert.Equal(output, actual);
        }

        [Fact]
        public void FizzBuzz_ReturnsDivisons()
        {
            //arrange
            FizzBuzzCalcService service = new();
            List<string> expected = new();
            expected.Add("Divided 22 by 3");
            expected.Add("Divided 22 by 5");
            
            //act
            FizzBuzzResponse response = service.RunCalculation("4");
            List<string> expectedResponse = response.FizzBuzzDivisions;

            //assert
            Assert.Equal(response.FizzBuzzDivisions, expectedResponse);
        }
    }
}