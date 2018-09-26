using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUIBackEnd.DAL;

namespace TUIBackEnd.BLL
{
    public interface IFlightBLL
    {
        List<Flight> GetFlightsList();
        Flight GetFlightsById(int id);
        void AddFlight(Flight flight);
        void UpdateFlight(Flight flight);



    }
}
