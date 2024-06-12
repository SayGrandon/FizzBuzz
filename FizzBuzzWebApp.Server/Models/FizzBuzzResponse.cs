using Newtonsoft.Json;

namespace FizzBuzzWebApp.Server.Models
{
    public class FizzBuzzResponse
    {
        [JsonProperty(nameof(FizzBuzzValue))]
        public string? FizzBuzzValue { get; set; }

        [JsonProperty(nameof(FizzBuzzDivisions))]
        public List<string>? FizzBuzzDivisions { get; set; }

    }
}
