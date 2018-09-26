using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUIBackEnd.DLL.Common;
using TUIBackEnd.Entities;

namespace TUIBackEnd.DLL
{
    
    public interface IFlightDAL : IGenericRepository<Flight, int>
    {
        //List<Flight> GetAll();
    }
}
