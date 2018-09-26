﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TUIFront.Areas.TUIFlight.Models
{
    public class AirportModel
    {
      
        public int Id { get; set; }
        public string AirportName { get; set; }
        public string AirportCode { get; set; }
        public int CountryId { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

    }
}