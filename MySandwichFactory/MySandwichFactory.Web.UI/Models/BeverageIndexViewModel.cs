using System.Collections.Generic;
using MySandwitchFactory.Common.Domains;
using MySandwitchFactory.Web.UI.Models;

namespace MySandwitchFactory.Web.UI.Controllers
{
    public class BeverageIndexViewModel
    {
        public Beverages Beverages;

        public BeverageListPartialViewModel BeverageListPartialViewModel { get; set; }
        public BeverageListPartialViewModel AllBeveragesList { get; set; }
        
    }

    public class BeverageListPartialViewModel
    {
        #region Constructorss

        public BeverageListPartialViewModel()
        {

        }

        public BeverageListPartialViewModel(List<BeverageViewModel> beverageses)
        {
            AllBeverages = beverageses;
        }

        #endregion

        public List<BeverageViewModel> AllBeverages { get; set; }
    }

     
}