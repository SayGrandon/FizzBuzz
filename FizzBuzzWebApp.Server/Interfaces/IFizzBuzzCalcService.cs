using FizzBuzzWebApp.Server.Models;

namespace FizzBuzzWebApp.Server.Interfaces
{
    public interface IFizzBuzzCalcService
    {
       public FizzBuzzResponse RunCalculation(string input);
    }
}
