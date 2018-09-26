using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUIBackEnd.Entities.Common;

namespace TUIBackEnd.Entities
{

    [Table("Flight")]
    public class Flight : Entity<int>
    {
        //public string FlightName { get; set; }
        //public DateTime? FlightDate { get; set; }

        public int DepartureAirport_Id { get; set; }

        public int DestinationAirport_Id { get; set; }

        public double FlightDistance { get; set; }

        public double AirCratfFuelComsumpDistance { get; set; }

        public double FlightTime { get; set; }

        public double FuelNeeded { get; set; }


        public double TakeOffEffort { get; set; }

        [ForeignKey("DepartureAirport_Id")]
        [InverseProperty("Flights")]
        public virtual Airport DepartureAirport { get; set; }



        [ForeignKey("DestinationAirport_Id")]
        public virtual Airport DestinationAirport { get; set; }



    }
}
