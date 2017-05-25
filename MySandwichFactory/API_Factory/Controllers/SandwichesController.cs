using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API_Factory.Models;
using Microsoft.Ajax.Utilities;
using MySandwitchFactory.Business;
using MySandwitchFactory.Common.Domains;
namespace API_Factory.Controllers
{
    public class SandwichesController : ApiController
    {
        readonly IFoodService _foodService;

        public SandwichesController()
        {
            _foodService = new FoodService();
        }

        public SandwichesController(IFoodService foodService)
        {
            _foodService = foodService;
        }

        public List<SandwichViewModel> GetAllSandwich()
        {
            var result = _foodService.GetAllSandwiches();
            GetSandwichResult getSandwichResult = new GetSandwichResult();

            getSandwichResult.CompanyDetailsModel = result.CompanyDetailsModel;
            getSandwichResult.SandwichModel = result.SandwichModel;

            List<SandwichViewModel> sandwichList = new List<SandwichViewModel>();

            foreach (var sm in getSandwichResult.SandwichModel)
            {
                SandwichViewModel sandwichViewModelItems = new SandwichViewModel(sm.SandwichName, sm.SandwichType, sm.Ingrediant, sm.Rate, sm.Price, sm.Image);

                sandwichList.Add(sandwichViewModelItems);
            }

            return sandwichList;
        }

        //private readonly Product[] _products = new Product[]
        //{
        //    new Product {Id = 12, Category = "Milky", Name = "Milk Shakes", Price = 200},
        //    new Product {Id = 12, Category = "Tea", Name = "Sri Lankan Tea", Price = 320},
        //    new Product {Id = 12, Category = "Food", Name = "Tuna Sandwich", Price = 320},
        //    new Product {Id = 12, Category = "Food", Name = "Submarieans", Price = 420},
        //    new Product {Id = 12, Category = "Milky", Name = "Orio Choco Shakes", Price = 450}
        //};

        //public IEnumerable<Product> GetAllProducts()
        //{
        //    return _products;
        //}


    }
}
