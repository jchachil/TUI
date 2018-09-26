using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUIBackEnd.Entities;
using TUIBackEnd.DLL.Common;

namespace TUIBackEnd.DLL
{
    //public class FlightDLL : IFlightDLL
    //{
    //    public List<Flight> GetAll()
    //    {
    //        List<Flight> lst = new List<Flight>();
    //        lst.Add(new Flight { Id = 1, FlightName = "azerty" });
    //        return lst;
    //    }
    //}

    //public class BugPriorityRepository : GenericRepository<BugPriority, int>, IBugPriorityRepository

    public class FlightDAL : GenericRepository<Flight, int>, IFlightDAL
    {
        public FlightDAL(TUIWebAppContext context)
            : base(context)
        {

        }
    }

}
