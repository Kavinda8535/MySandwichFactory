using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySandwitchFactory.Web.UI
{
    public class SandwichViewModel
    {
        #region Constructors

        public SandwichViewModel()
        {
        }

        public SandwichViewModel(string sandwichName, string sandwichType, string ingrediants, int rate, double price)
        {
            SandwichName = sandwichName;
            SandwichType = sandwichType;
            Ingrediant = ingrediants;
            Rate = rate;
            Price = price;
        }

        #endregion

        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "-")]
        [Display(Name = "Name")]
        public string SandwichName { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "-")]
        [Display(Name = "Types")]
        public string SandwichType { get; set; }

        //[DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "-")]
        [Display(Name = "Ingrediants")]
        public string Ingrediant { get; set; }

        //[DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "-")]
        [Display(Name = "Rate")]
        public int Rate { get; set; }

        //[DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "-")]
        [Display(Name = "Price")]
        public double Price { get; set; }

    }
}
