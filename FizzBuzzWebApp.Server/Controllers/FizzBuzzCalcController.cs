using FizzBuzzWebApp.Server.Interfaces;
using FizzBuzzWebApp.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzzWebApp.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FizzBuzzCalcController : ControllerBase
    {
        private readonly ILogger<FizzBuzzCalcController> _logger;
        private IFizzBuzzCalcService _fizzBuzzCalcService;

        public FizzBuzzCalcController(ILogger<FizzBuzzCalcController> logger, IFizzBuzzCalcService fizzBuzzCalcService)
        {
            _logger = logger;
            _fizzBuzzCalcService = fizzBuzzCalcService;
        }

        //GET: FizzBuzz/5
        [HttpGet("{input}")]
        public FizzBuzzResponse GetFizzBuzz(string input)
        {
            try
            {
                _logger.LogInformation("GetFizzBuzz endpoint being evaluated...");
                return _fizzBuzzCalcService.RunCalculation(input);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return new FizzBuzzResponse
                {
                    FizzBuzzValue = "Invalid Item"
                };
            }
        }
    }
}
