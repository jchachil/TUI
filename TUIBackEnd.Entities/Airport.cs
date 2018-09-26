using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUIBackEnd.Entities.Common;

namespace TUIBackEnd.Entities
{

    [Table("Airport")]
    public class Airport: Entity<int>
    {
        public string AirportName { get; set; }
        public string AirportCode { get; set; }

        public int Country_Id { get; set; }

        [ForeignKey("Country_Id")]
        public virtual Country Country { get; set; }

        public virtual ICollection<Flight> Flights { get; set; }

        public double  Latitude { get; set; }
        public double  Longitude { get; set; }



    }
}
