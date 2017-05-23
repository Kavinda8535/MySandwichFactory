using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySandwitchFactory.Business;
using MySandwitchFactory.Web.UI.Models;

namespace MySandwitchFactory.Web.UI.Controllers
{
    public class BeveragesController : Controller
    {

        readonly IFoodService _foodService;

        public BeveragesController(IFoodService foodService)
        {
            _foodService = foodService;
        }

        //
        // GET: /Beverages/

        public ActionResult Index()
        {
            
            return View(ShowAll());
        }

        public BeverageIndexViewModel ShowAll()
        {
            var result = _foodService.GetAllBeverages();
            GetBeverageResult beverageResult = new GetBeverageResult();

            beverageResult.Beverageses = result.Beverageses;

            BeverageIndexViewModel beverageIndexViewModel = new BeverageIndexViewModel();

            List<BeverageViewModel> beverageList = new List<BeverageViewModel>();

            foreach (var bm in beverageResult.Beverageses)
            {
                BeverageViewModel beverageViewModelIteams = new BeverageViewModel(bm.Name, bm.Price, bm.Category, bm.Sweetness, bm.Image);

                beverageList.Add(beverageViewModelIteams);
            }

            beverageIndexViewModel.AllBeveragesList = new BeverageListPartialViewModel(beverageList);

            return beverageIndexViewModel;
        }

    }

    
}
