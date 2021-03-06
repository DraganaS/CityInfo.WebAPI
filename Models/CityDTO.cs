﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.WebAPI.Models
{
    public class CityDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int NumberOfPointOfInterest { get
            {
                return PointsOfInterest.Count;
            } }

        public ICollection<PointsOfInterestDTO> PointsOfInterest { get; set; } = new List<PointsOfInterestDTO>();
    }
}
