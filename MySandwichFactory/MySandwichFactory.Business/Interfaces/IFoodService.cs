using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySandwitchFactory.DataAccess.DataModels;

namespace MySandwitchFactory.Business
{
    public interface IFoodService
    {
        List<SandwichModel> GetAllSandwiches();
    }
}
