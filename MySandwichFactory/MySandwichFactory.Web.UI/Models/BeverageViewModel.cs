using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using DotNetOpenAuth.OpenId.Extensions.AttributeExchange;

namespace MySandwitchFactory.Web.UI.Models
{
    public class BeverageViewModel
    {
        #region Constructors

        public BeverageViewModel()
        {
        }

        public BeverageViewModel(string name, double price, string category, int sweetness, string image)
        {
            Name = name;
            Price = price;
            Category = category;
            Sweetness = sweetness;
            Image = image;
        }

        #endregion

        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "-")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        
        [Display(Name = "Price")]
        public double Price { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "-")]
        [Display(Name = "Category")]
        public string Category { get; set; }
        
        [Display(Name = "Sweetness")]
        public int Sweetness { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "~/Images/Beverages/WatermelonJuice.jpg")]
        [Display(Name = "Image")]
        public string Image { get; set; }
    }
}