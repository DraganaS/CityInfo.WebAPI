using CityInfo.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.WebAPI
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDTO> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDTO>()
            { new CityDTO()
            {
                Id = 1,
                Name = "Paris",
                Description = "Hey from Paris",
                PointsOfInterest = new List<PointsOfInterestDTO>()
                {
                    new PointsOfInterestDTO()
                    {
                         Id = 1,
                         Name = "Eifel tower",
                         Description = "Hey from Eifel tower",
                    },
                     new PointsOfInterestDTO()
                    {
                         Id = 1,
                         Name = "Eifel tower",
                         Description = "Hey from Eifel tower",
                    }
                }
            },
            new CityDTO()
            {
                Id = 2,
                Name = "London",
                Description = "Hey from London",
                PointsOfInterest = new List<PointsOfInterestDTO>()
                {
                    new PointsOfInterestDTO()
                    {
                         Id = 1,
                         Name = "Eifel tower",
                         Description = "Hey from Eifel tower",
                    }
                }
            },
            };

        }
    }
}
