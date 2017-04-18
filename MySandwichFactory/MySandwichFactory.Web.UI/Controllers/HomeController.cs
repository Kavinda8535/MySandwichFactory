using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AndrSandwich.Business;
using AutoMapper;
using MySandwitchFactory.Web.UI.Models;

namespace AndrSandwich.Web.UI.Controllers
{
    public class HomeController : Controller
    {
        IFoodService _foodService;

        public HomeController(IFoodService foodService)
        {
            _foodService = foodService;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public List<SandwichViewModel> ShowAll()
        {
            //Mapper.CreateMap()
            
            // Need to set a autio mapper to map Bussiness model with UI view Model
            List<SandwichViewModel> sandwiches = _foodService.GetAllSandwiches();
            return sandwiches;
        }

        
    }
}
