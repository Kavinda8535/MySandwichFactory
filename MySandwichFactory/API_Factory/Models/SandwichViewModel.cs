﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Factory.Models
{
    public class SandwichViewModel
    {
        #region Constructors

        public SandwichViewModel()
        {
        }

        public SandwichViewModel(string sandwichName, string sandwichType, string ingrediants, int rate, double price, string image)
        {
            SandwichName = sandwichName;
            SandwichType = sandwichType;
            Ingrediant = ingrediants;
            Rate = rate;
            Price = price;
            Image = image;

        }

        #endregion

        //[DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "-")]
        //[Display(Name = "Name")]
        public string SandwichName { get; set; }

        //[DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "-")]
        //[Display(Name = "Types")]
        public string SandwichType { get; set; }

        //[DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "-")]
        //[Display(Name = "Ingrediants")]
        public string Ingrediant { get; set; }

        //[DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "-")]
        //[Display(Name = "Rate")]
        public int Rate { get; set; }

        //[DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "-")]
        //[Display(Name = "Price")]
        public double Price { get; set; }

        //[Display(Name = "Image")]
        public string Image { get; set; }
    }
}