using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySandwitchFactory.Portal.Common
{
    public enum BeverageCategoriesEnum
    {
        [Description("Fresh Fruit Juice")]
        FreshFruitJuice,
        Alcoholic,
//[Display(Name = "Non-Alcoholic")]
        [Description("Non-Alcoholic")]
        NonAlcoholic,
        Tea,
        Milky,
        SoftDrinks,
        Smoothies,
        Macchiato,
        Crush
    }
}
