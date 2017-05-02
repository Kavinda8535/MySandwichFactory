using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySandwitchFactory.Common.Domains;
using MySandwitchFactory.Portal.Common;

namespace MySandwitchFactory.Business
{
    public class FoodService : IFoodService
    {
        private readonly IFoodRepository _foodRepository;

        public FoodService(IFoodRepository foodRepository)
        {
            _foodRepository = foodRepository;
        }

        public FoodService()
        {
            // TODO: Complete member initialization
        }

        //public IEnumerable<SandwichModel> GetAllSandwiches()
        //{

        //    var result = _foodRepository.GetAllSandwiches();
        //    return result;
        //}
        public GetSandwichResult GetAllSandwiches()
        {
            var result = new GetSandwichResult();
            
            result.SandwichModel = _foodRepository.GetAllSandwiches();
            result.CompanyDetailsModel = _foodRepository.GetCompanyName();
            //throw new NotImplementedException();

            return result;
        }

        
    }
}
