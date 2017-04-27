using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySandwitchFactory.Web.UI.Services;

namespace MySandwitchFactory.Web.UI.Controllers
{
    public class UnityDemoController : Controller
    {

        private readonly ILocalWeaherServiceProvider _localWeaherServiceProvider;
        private readonly IFacebookConnectionManager _facebookConnectionManager;

        public UnityDemoController()
            : this(new LocalWeatherServiceProvider(), new FacebookConnectionManager(System.Configuration.ConfigurationManager.AppSettings["userName"],
                System.Configuration.ConfigurationManager.AppSettings["authenticationToken"],
                System.Configuration.ConfigurationManager.AppSettings["faceBookAuthUrl"]))
        {

        }

        public UnityDemoController(ILocalWeaherServiceProvider localWeaherServiceProvider, IFacebookConnectionManager facebookConnectionManager)
        {
            _localWeaherServiceProvider = localWeaherServiceProvider;
            _facebookConnectionManager = facebookConnectionManager;

        }

        //
        // GET: /UnityDemo/

        public ActionResult Index()
        {
            if (_facebookConnectionManager.AuthenticateUser())
            {
                string currentWeatherInMyArea = _localWeaherServiceProvider.GetLocalWeatherByZipCode("0006");
            }
            
            return View();
        }

    }
}
