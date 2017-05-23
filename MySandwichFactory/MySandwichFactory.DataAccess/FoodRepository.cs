using System;
using System.Collections.Generic;
using MySandwitchFactory.Common.Domains;
using MySandwitchFactory.Portal.Common;
using SandwichModel = MySandwitchFactory.Common.Domains.SandwichModel;

namespace MySandwitchFactory.Common
{
    public class FoodRepository : IFoodRepository
    {
        //public FoodRepository()
        //{

        //}

        public List<SandwichModel> GetAllSandwiches()
        {
            var result = new List<SandwichModel>();
            var obj1 = new SandwichModel { SandwichName = "Chicken Paillard", SandwichType = "Non-Veg", Ingrediant = "Lightly spiced grilled chicken topped with sun dried tomatos, olives, tomatoes and lettuce.", Rate = 3, Price = 530.00, Image = "~/Images/Sandwiches/chicken_paillard.jpg" };
            var obj2 = new SandwichModel { SandwichName = "Beef Master", SandwichType = "Non-Veg", Ingrediant = "For the health conscious beef lover. A filling sandwich packed with sliced cured beef, tomato, grilled onions and lettuce topped with mustard.", Rate = 4, Price = 540.00, Image = "~/Images/Sandwiches/Beef-Master.jpeg" };
            var obj3 = new SandwichModel { SandwichName = "Trim Chicken", SandwichType = "Non-Veg", Ingrediant = "A healthy and wholesome Chicken sandwich, layered with grilled chicken, tomato, lettuce and grilled onions. ", Rate = 3, Price = 430.00, Image = "~/Images/Sandwiches/Trim-chicken.jpg" };
            var obj4 = new SandwichModel { SandwichName = "The Real Slim Turkey", SandwichType = "Non-Veg", Ingrediant = "The ultimate Turkey sandwich. Stuffed with Turkey, lettuce, bean sprouts, English cucumber and guacamole.", Rate = 5, Price = 910.00, Image = "~/Images/Sandwiches/Turkey Sandwich.jpg" };
            var obj5 = new SandwichModel { SandwichName = "Lively Tuna", SandwichType = "Non-Veg", Ingrediant = "A blast of flavor with Tuna, tomato, English cucumber and bean sprouts.", Rate = 3, Price = 440.00, Image = "~/Images/Sandwiches/Lively-TUNA-SANDWICH.jpg" };
            var obj6 = new SandwichModel { SandwichName = "Veg Might", SandwichType = "Veg", Ingrediant = "A refreshing variety of creamy avocado, English cucumber, lettuce and tomato.", Rate = 4, Price = 330.00, Image = "~/Images/Sandwiches/veg-cheese-sandwiches.jpg" };
            var obj7 = new SandwichModel { SandwichName = "The Godfather", SandwichType = "Non-Veg", Ingrediant = "A delicious Italian feast for those of you looking to build up. A great combination of pepperoni , salami, onions grilled/raw, lettuce, 2 slices of cheese.", Rate = 4, Price = 450.00, Image = "~/Images/Sandwiches/godfather-graham-avenue-meats.jpg" };
            var obj8 = new SandwichModel { SandwichName = "Tuna Might", SandwichType = "Non-Veg", Ingrediant = "An appetizing tortilla filled with a spicy Mexican mixture of your choice of tuna, topped up with gooey cheese.", Rate = 5, Price = 559.99, Image = "~/Images/Sandwiches/tuna-Might-sandwich.jpg" };
            var obj9 = new SandwichModel { SandwichName = "The Real Slim Beef", SandwichType = "Non-Veg", Ingrediant = "Pulled Beef smothered in BBQ sauce, cheese & grilled onions", Rate = 4, Price = 420.00, Image = "~/Images/Sandwiches/slim-beef.jpeg" };
            var obj10 = new SandwichModel { SandwichName = "Veg Master", SandwichType = "Veg", Ingrediant = "Savor this flavorful combination of paneer/soya served on a bed of lettuce, tomato and cheese, wrapped in a soft taco.", Rate = 4, Price = 590.00 , Image = "~/Images/Sandwiches/veggie-master-sandwich.jpg"};

            result.Add(obj1);
            result.Add(obj2);
            result.Add(obj3);
            result.Add(obj4);
            result.Add(obj5);
            result.Add(obj6);
            result.Add(obj7);
            result.Add(obj8);
            result.Add(obj9);
            result.Add(obj10);

            return result;
        }

        public CompanyDetailsModel GetCompanyName()
        {
            var companyDetailsModel = new CompanyDetailsModel
            {
                CompanyName = "Sandwich Factory",
                CompanyMoto = "Socialization and food is pretty much inseparable",
                StartDate = DateTime.Now
            };

            return companyDetailsModel;
        }
        
        public List<Beverages> GetAllBeverages()
        {
            var result = new List<Beverages>();

            var obj1 = new Beverages
            {
                Name = "Water Melon Juice",
                Price = 360.00,
                Sweetness = 2,
                Category = BeverageCategoriesEnum.FreshFruitJuice.ToString()
            };
            var obj2 = new Beverages
            {
                Name = "Lime Juice",
                Price = 360.00,
                Sweetness = 2,
                Category = BeverageCategoriesEnum.FreshFruitJuice.ToString()
            };
            var obj3 = new Beverages
            {
                Name = "Lime Soda",
                Price = 360.00,
                Sweetness = 2,
                Category = BeverageCategoriesEnum.FreshFruitJuice.ToString()
            };
            var obj4 = new Beverages
            {
                Name = "Orange Juice",
                Price = 400.00,
                Sweetness = 2,
                Category = BeverageCategoriesEnum.FreshFruitJuice.ToString()
            };
            var obj5 = new Beverages
            {
                Name = "Oragne & Ginger",
                Price = 530.00,
                Sweetness = 2,
                Category = BeverageCategoriesEnum.Smoothies.ToString()
            };
            var obj6 = new Beverages
            {
                Name = "Watermelon",
                Price = 530.00,
                Sweetness = 2,
                Category = BeverageCategoriesEnum.Smoothies.ToString()
            };
            var obj7 = new Beverages
            {
                Name = "Iced Caramel",
                Price = 680.00,
                Sweetness = 2,
                Category = BeverageCategoriesEnum.Macchiato.ToString()
            };
            var obj8 = new Beverages
            {
                Name = "Espresso",
                Price = 380.00,
                Sweetness = 2,
                Category = BeverageCategoriesEnum.Milky.ToString()
            }; 
            var obj9 = new Beverages
            {
                Name = "Caffe Americano",
                Price = 460.00,
                Sweetness = 2,
                Category = BeverageCategoriesEnum.Milky.ToString()
            };
            var obj10 = new Beverages
            {
                Name = "Hot Chocolate",
                Price = 550.00,
                Sweetness = 2,
                Category = BeverageCategoriesEnum.Milky.ToString()
            };
            var obj11 = new Beverages
            {
                Name = "Caffe Mocha",
                Price = 580.00,
                Sweetness = 2,
                Category = BeverageCategoriesEnum.Milky.ToString()
            }; 
            var obj12 = new Beverages
            {
                Name = "​Flat White",
                Price = 450.00,
                Sweetness = 2,
                Category = BeverageCategoriesEnum.Milky.ToString()
            };
            var obj13 = new Beverages
            {
                Name = "​English Breakfast Tea",
                Price = 300.00,
                Sweetness = 2,
                Category = BeverageCategoriesEnum.Tea.ToString()
            };
            var obj14 = new Beverages
            {
                Name = "​Hot Tea Ceylon Supreme",
                Price = 300.00,
                Sweetness = 2,
                Category = BeverageCategoriesEnum.Tea.ToString()
            };
            var obj15 = new Beverages
            {
                Name = "​Cookies N Coffee Shake",
                Price = 680.00,
                Sweetness = 2,
                Category = BeverageCategoriesEnum.Milky.ToString()
            };
            var obj16 = new Beverages
            {
                Name = "​Irish Coffee Shake",
                Price = 680.00,
                Sweetness = 2,
                Category = BeverageCategoriesEnum.Milky.ToString()
            };
            var obj17 = new Beverages
            {
                Name = "​Chocolate Ice Cream Shakes",
                Price = 600.00,
                Sweetness = 2,
                Category = BeverageCategoriesEnum.Milky.ToString()
            };
            var obj18 = new Beverages
            {
                Name = "​Oreo Shake",
                Price = 680.00,
                Sweetness = 2,
                Category = BeverageCategoriesEnum.Milky.ToString()
            };
            var obj19 = new Beverages
            {
                Name = "​Peach Ice Tea",
                Price = 430.00,
                Sweetness = 2,
                Category = BeverageCategoriesEnum.Tea.ToString()
            };
            var obj20 = new Beverages
            {
                Name = "​Lemon Ice Tea",
                Price = 430.00,
                Sweetness = 2,
                Category = BeverageCategoriesEnum.Tea.ToString()
            };

            result.Add(obj1);
            result.Add(obj2);
            result.Add(obj3);
            result.Add(obj4);
            result.Add(obj5);
            result.Add(obj6);
            result.Add(obj7);
            result.Add(obj8);
            result.Add(obj9);
            result.Add(obj10);
            result.Add(obj11);
            result.Add(obj12);
            result.Add(obj13);
            result.Add(obj14);
            result.Add(obj15);
            result.Add(obj16);
            result.Add(obj17);
            result.Add(obj18);
            result.Add(obj19);
            result.Add(obj20);
            
            return result;
        }


        //public List<SandwichModel> GetAllSandwiches()
        //{
        //    throw new NotImplementedException();
        //}


        
    }
}
