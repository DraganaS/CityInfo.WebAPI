using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.WebAPI.Controllers
{
    [Route("api/cities")]
    public class CityController : Controller
    {
        [HttpGet]
        public IActionResult GetCities()
        {
            return Ok(new JsonResult(CitiesDataStore.Current.Cities));
            //return new JsonResult(CitiesDataStore.Current.Cities);
            //    new List<object>()
            //{
            //    new {id = 1, Name ="Paris"},
            //    new {id =2, Name ="Mardid"}
            //}
            
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
            var temp = new JsonResult(CitiesDataStore.Current.Cities.FirstOrDefault(f => f.Id == id));
            if (temp == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(temp);
            }
            //return new JsonResult(CitiesDataStore.Current.Cities.FirstOrDefault(f => f.Id == id));        
        }
    }
}
