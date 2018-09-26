using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUIBackEnd.DAL;

namespace TUIBackEnd.BLL
{
    /// <summary>
    /// Airport BLL class
    /// </summary>
    public class AirportBLL: IAirportBLL
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
        /// Get all Airports from Database
        /// </summary>
        /// <returns></returns>
        public List<Airport> GetAirportsList()
        {
            return Data.Airports.ToList();
        }
    }
}
