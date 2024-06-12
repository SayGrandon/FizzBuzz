using FizzBuzzWebApp.Server.Interfaces;
using FizzBuzzWebApp.Server.Models;

namespace FizzBuzzWebApp.Server.Services
{
    public class FizzBuzzCalcService : IFizzBuzzCalcService
    {
        private FizzBuzzResponse _response = new();
        private List<string> _divisions = new();

        public FizzBuzzResponse RunCalculation(string input)
        {
            //checks for nulls and non digits
            if (string.IsNullOrEmpty(input) || !int.TryParse(input, out int numberInput))
            {
                return new FizzBuzzResponse
                {
                    FizzBuzzValue = "Invalid Item"
                };
            }
            if (numberInput % 3 == 0)
            {
                _response.FizzBuzzValue += ("Fizz");
            }
            else
            {
                _divisions.Add($"Divided {numberInput} by 3");
            }
            if (numberInput % 5 == 0)
            {
                _response.FizzBuzzValue += ("Buzz");
            }
            else
            {
                _divisions.Add($"Divided {numberInput} by 5");
            }

            //returns divisions performed
            if (string.IsNullOrEmpty(_response.FizzBuzzValue))
            {
                return new FizzBuzzResponse
                {
                    FizzBuzzDivisions = _divisions
                };
            }
            return _response;
        }
    }
}
