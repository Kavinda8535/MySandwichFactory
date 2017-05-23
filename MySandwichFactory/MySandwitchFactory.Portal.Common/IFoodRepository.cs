using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySandwitchFactory.Common.Domains;

namespace MySandwitchFactory.Portal.Common
{
    public interface IFoodRepository
    {
        List<SandwichModel> GetAllSandwiches();
        CompanyDetailsModel GetCompanyName();
        List<Beverages> GetAllBeverages();
    }
}
