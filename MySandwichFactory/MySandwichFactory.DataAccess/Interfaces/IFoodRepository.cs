using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySandwitchFactory.DataAccess.DataModels;

namespace MySandwitchFactory.DataAccess
{
    public interface IFoodRepository
    {
        List<SandwichModel> GetAllSandwiches();
    }
}
