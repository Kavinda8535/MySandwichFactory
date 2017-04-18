using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AndrSandwich.DataAccess.DataModels;

namespace AndrSandwich.Business
{
    public interface IFoodService
    {
        List<SandwichModel> GetAllSandwiches();
    }
}
