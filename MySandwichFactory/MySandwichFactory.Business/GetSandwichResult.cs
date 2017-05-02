using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySandwitchFactory.Common.Domains;

namespace MySandwitchFactory.Business
{
    public class GetSandwichResult
    {
        public List<SandwichModel> SandwichModel { get; set; }
        public CompanyDetailsModel CompanyDetailsModel { get; set; }
    }
}
