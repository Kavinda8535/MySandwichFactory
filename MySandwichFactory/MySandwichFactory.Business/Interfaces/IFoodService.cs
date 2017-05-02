using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySandwitchFactory.Common.Domains;


namespace MySandwitchFactory.Business
{
    public interface IFoodService
    {
       GetSandwichResult GetAllSandwiches();
    }
}
