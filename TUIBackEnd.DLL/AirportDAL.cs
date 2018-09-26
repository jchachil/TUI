using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUIBackEnd.DLL.Common;
using TUIBackEnd.Entities;

namespace TUIBackEnd.DLL
{
    public class AirportDAL : GenericRepository<Airport, int>, IAirportDAL
    {
        public AirportDAL(TUIWebAppContext context)
            : base(context)
        {

        }
    }
}
