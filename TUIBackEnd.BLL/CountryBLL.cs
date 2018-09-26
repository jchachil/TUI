using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUIBackEnd.DAL;

namespace TUIBackEnd.BLL
{
    /// <summary>
    /// Country BLL Class
    /// </summary>
    public class CountryBLL :ICountryBLL
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
        /// /// Get all countries from Database
        /// </summary>
        /// <returns></returns>
        public List<Country> GetCountriesList()
        {
            return Data.Countries.ToList();
        }
    }
}
