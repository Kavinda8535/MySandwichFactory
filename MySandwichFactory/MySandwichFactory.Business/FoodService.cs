using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySandwitchFactory.DataAccess;
using MySandwitchFactory.DataAccess.DataModels;

namespace MySandwitchFactory.Business
{
    public class FoodService : IFoodService
    {

        public List<SandwichModel> GetAllSandwiches()
        {
            IFoodRepository repository = new FoodRepository();
            var result = repository.GetAllSandwiches();
            return result;
        }
    }
}
