using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySandwitchFactory.Web.UI.Services
{
    public class LocalWeatherServiceProvider : ILocalWeaherServiceProvider
    {
        public string GetLocalWeatherByZipCode(string zipcode)
        {
            return "Its is snowing right now in your Area : " + zipcode;
        }
    }
}