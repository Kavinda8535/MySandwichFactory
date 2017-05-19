using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Microsoft.Ajax.Utilities;
using MySandwitchFactory.Business;
using MySandwitchFactory.Web.UI.Models;

namespace MySandwitchFactory.Web.UI.Controllers
{
    public class MySandwichesController : Controller
    {
        //
        // GET: /MySandwiches/

        readonly IFoodService _foodService;

        public MySandwichesController() : this(new FoodService())
        {

        }

        public MySandwichesController(IFoodService foodService)
        {
            _foodService = foodService;
        }

        public ActionResult Index()
        {
            return View(ShowAll());
        }

        public HomeIndexViewModel ShowAll()
        {
            //IFoodService foodService = DependencyResolver.Current.GetService<IFoodService>();

            //Mapper.CreateMap()

            // Need to set a autio mapper to map Bussiness model with UI view Model
            //var sandwiches = foodService.GetAllSandwiches();

            var result = _foodService.GetAllSandwiches();
            GetSandwichResult getSandwichResult = new GetSandwichResult();

            getSandwichResult.CompanyDetailsModel = result.CompanyDetailsModel;
            getSandwichResult.SandwichModel = result.SandwichModel;

            HomeIndexViewModel homeIndexViewModel = new HomeIndexViewModel();
            
            List<SandwichViewModel> sadwichList = new List<SandwichViewModel>(); 

            foreach (var sm in getSandwichResult.SandwichModel)
            {
                SandwichViewModel sandwichViewModelItems = new SandwichViewModel(sm.SandwichName, sm.SandwichType,
                    sm.Ingrediant, sm.Rate, sm.Price);

                sadwichList.Add(sandwichViewModelItems);

                //homeIndexViewModel.SandwichViewModel.Ingrediant = sm.Ingrediant;
                //homeIndexViewModel.SandwichViewModel.Price = sm.Price;
                //homeIndexViewModel.SandwichViewModel.Rate = sm.Rate;
                //homeIndexViewModel.SandwichViewModel.SandwichName = sm.SandwichName;
                //homeIndexViewModel.SandwichViewModel.SandwichType = sm.SandwichType;

                //homeIndexViewModel.AllSandwich.Add(sandwichViewModel);

                
            }

            homeIndexViewModel.AllSandwichList = new HomeSandwichListPartialViewModel(sadwichList);
            homeIndexViewModel.Details = new CompanyDetailsViewModel(getSandwichResult.CompanyDetailsModel.CompanyName, getSandwichResult.CompanyDetailsModel.CompanyMoto, getSandwichResult.CompanyDetailsModel.StartDate);

            //homeIndexViewModel.Details.CompanyMoto = getSandwichResult.CompanyDetailsModel.CompanyMoto;
            //homeIndexViewModel.Details.CompanyName = getSandwichResult.CompanyDetailsModel.CompanyName;
            //homeIndexViewModel.Details.StartDate = getSandwichResult.CompanyDetailsModel.StartDate;

            //homeIndexViewModel.AllSandwich = getSandwichResult.SandwichModel

            //Mapper.Map<HomeIndexViewModel, GetSandwichResult>(result);

            //homeIndexViewModel.AllSandwich = result.SandwichModel;

            //homeIndexViewModel.Details = result.CompanyDetailsModel;

            SandwichViewModel sandwichViewModels1; //= Mapper.Map<SandwichViewModel>(sandwiches);

            return homeIndexViewModel;
        }
    }
}
