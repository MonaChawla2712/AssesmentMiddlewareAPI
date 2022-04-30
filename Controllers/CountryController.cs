using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MiddlewareAPI.Controllers
{
    [Route("country")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        [HttpGet("getAllCountries")]
        public IEnumerable<Country> GetAllCountries()
        {
            return GetCountryDetails();
        }

        private List<Country> GetCountryDetails()
        {
            return new List<Country>()
            {
                new Country()
                {
                    CountryId = 1, CountryName = "India"
                },
                new Country()
                {
                    CountryId = 2, CountryName = "USA"
                },
                new Country()
                {
                    CountryId = 3, CountryName = "Germany"
                }
            };
        }
    }
}
