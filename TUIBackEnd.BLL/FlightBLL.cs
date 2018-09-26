using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUIBackEnd.DAL;


namespace TUIBackEnd.BLL
{
    /// <summary>
    /// Flight BLL Class
    /// </summary>
    public class FlightBLL :IFlightBLL
    {
        
        private TUIEntities _Data = null;
        protected TUIEntities Data
        {
            get
            {
                if (_Data == null)
                {
                    _Data = new TUIEntities();
                }

                return _Data;
            }
        }


        /// <summary>
        /// Get all flights data from DB
        /// </summary>
        /// <returns></returns>
        public List<Flight> GetFlightsList()
        {
            return Data.Flights.ToList();
        }

        /// <summary>
        /// Get Flight By Id from database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Flight GetFlightsById(int id)
        {
            return Data.Flights.FirstOrDefault(elt=>elt.Id== id);
        }

        /// <summary>
        /// Add Flight to database
        /// </summary>
        /// <param name="flight"></param>
        public void AddFlight(Flight flight)
        {
            Data.Flights.Add(flight);
            Data.SaveChanges();
        }

        /// <summary>
        /// Update Flight
        /// </summary>
        /// <param name="flight"></param>
        public void UpdateFlight(Flight flight)
        {
            Data.Flights.Find(flight.Id);
            Data.SaveChanges();
        }


    }
}
