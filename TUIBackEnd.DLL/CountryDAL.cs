using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUIBackEnd.Entities;
using TUIBackEnd.DLL.Common;


namespace TUIBackEnd.DLL
{
    public class CountryDAL : GenericRepository<Country, int>, ICountryDAL
    {
        public CountryDAL(TUIWebAppContext context)
            : base(context)
        {

        }
    }
}
