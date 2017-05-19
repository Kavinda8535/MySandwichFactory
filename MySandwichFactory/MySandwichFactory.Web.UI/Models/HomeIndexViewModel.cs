using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySandwitchFactory.Web.UI.Models
{
    public class HomeIndexViewModel
    {

        public SandwichViewModel SandwichViewModel;

        public HomeSandwichListPartialViewModel AllSandwichList { get; set; }
        
        public CompanyDetailsViewModel Details { get; set; }
    }

    public class HomeSandwichListPartialViewModel
    {
        #region Constructors

        public HomeSandwichListPartialViewModel()
        {

        }

        public HomeSandwichListPartialViewModel(List<SandwichViewModel> allsandwich)
        {
            AllSandwich = allsandwich;
        }

        #endregion

        public List<SandwichViewModel> AllSandwich { get; set; }

    }
}