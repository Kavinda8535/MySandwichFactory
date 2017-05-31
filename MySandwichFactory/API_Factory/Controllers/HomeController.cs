using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySandwitchFactory.Business;

namespace API_Factory.Controllers
{
    public class HomeController : Controller
    {
         readonly IFoodService _foodService;

        //public SandwichesController()
        //{
            //_foodService = new FoodService();
        //}

         public HomeController(IFoodService foodService)
        {
            _foodService = foodService;
        }

        public ActionResult Index()
        {
            _foodService.GetAllSandwiches();

            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
