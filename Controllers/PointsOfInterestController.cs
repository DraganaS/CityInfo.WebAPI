using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.WebAPI.Controllers
{
    [Route("api/cities")]
    public class PointsOfInterestController : Controller
    {
        [HttpGet("{cityId}/pointsofinterest")]
        public IActionResult GetPointsOfInterest(int cityId)
        {
            var result = CitiesDataStore.Current.Cities.FirstOrDefault(f => f.Id == cityId);
            if(result == null)
            {
                return NotFound();
            }
            return Ok(result.PointsOfInterest);
        }

        [HttpGet("{cityId}/pointsofinterest/{id}")]
        public IActionResult GetPointOfInterest(int cityId, int pointOfInterest)
        {
            var result = CitiesDataStore.Current.Cities.FirstOrDefault(f => f.Id == cityId);
            if (result == null)
            {
                return NotFound();
            }

            var resultChild = CitiesDataStore.Current.Cities.FirstOrDefault(f => f.Id == cityId).PointsOfInterest.FirstOrDefault(p => p.Id == pointOfInterest);

            if(resultChild == null)
            {
                NotFound();
            }
            return Ok(result.PointsOfInterest);
        }
    }
}
