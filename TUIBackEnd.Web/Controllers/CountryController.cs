using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TUIBackEnd.BLL;
using TUIBackEnd.DAL;
using TUIBackEnd.Models;
using TUIBackEnd.Web.Helper;

namespace TUIBackEnd.Web.Controllers
{
    /// <summary>
    /// country controller Class
    /// </summary>
    public class CountryController : BaseController
    {

        ICountryBLL _countryBLL;
        public CountryController(ICountryBLL countryBLL)
        {
            _countryBLL = countryBLL;

        }

        /// <summary>
        /// Get all countries from database
        /// </summary>
        /// <returns></returns>
        [Route(WebApiRoutes.GetAllCountriesListActionName)]
        public List<CountryModel> GetAllCountriesList()
        {            
            List<CountryModel> model = new List<CountryModel>();
            List<Country> countriesList = _countryBLL.GetCountriesList().ToList();
            model = AutoMapper.Mapper.Map<List<CountryModel>>(countriesList);

            return model;
        }
    }
}
