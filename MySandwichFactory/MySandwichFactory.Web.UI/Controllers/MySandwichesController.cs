using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using MySandwitchFactory.Business;

namespace MySandwitchFactory.Web.UI.Controllers
{
    public class MySandwichesController : Controller
    {
        //
        // GET: /MySandwiches/

        readonly IFoodService _foodService;

        public MySandwichesController()
            : this(new FoodService())
        {

        }

        public MySandwichesController(IFoodService foodService)
        {
            _foodService = foodService;
        }

        public ActionResult Index()
        {
            ShowAll();

            return View();
        }

        public SandwichViewModel ShowAll()
        {
            IFoodService foodService = DependencyResolver.Current.GetService<IFoodService>();

            //Mapper.CreateMap()

            // Need to set a autio mapper to map Bussiness model with UI view Model
            //var sandwiches = foodService.GetAllSandwiches();

            var sandwiches = _foodService.GetAllSandwiches();

            SandwichViewModel sandwichViewModels1; //= Mapper.Map<SandwichViewModel>(sandwiches);

            return null;
        }
    }
}
