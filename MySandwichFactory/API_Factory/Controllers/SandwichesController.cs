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
        private readonly IFoodService _foodService;

        public SandwichesController(IFoodService foodService)
        {
            _foodService = foodService;
        }

        public List<SandwichModel> GetAllSandwich()
        {
            var result = _foodService.GetAllSandwiches();
            GetSandwichResult getSandwichResult = new GetSandwichResult();

            getSandwichResult.CompanyDetailsModel = result.CompanyDetailsModel;
            getSandwichResult.SandwichModel = result.SandwichModel;

            return result.SandwichModel;
        }
    }
}
