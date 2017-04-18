using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AndrSandwich.DataAccess.DataModels;

namespace AndrSandwich.DataAccess
{
    public class FoodRepository : IFoodRepository
    {
        public List<SandwichModel> GetAllSandwiches()
        {
            List<SandwichModel> result = new List<SandwichModel>();
            var obj1 = new SandwichModel { SandwichName = "Chicken Paillard", SandwichType = "Non-Veg", Ingrediant = "Lightly spiced grilled chicken topped with sun dried tomatos, olives, tomatoes and lettuce.", Rate = 3, Price = 530.00 };
            var obj2 = new SandwichModel { SandwichName = "Beef Master", SandwichType = "Non-Veg", Ingrediant = "For the health conscious beef lover. A filling sandwich packed with sliced cured beef, tomato, grilled onions and lettuce topped with mustard.", Rate = 4, Price = 540.00 };
            var obj3 = new SandwichModel { SandwichName = "Trim Chicken", SandwichType = "Non-Veg", Ingrediant = "A healthy and wholesome Chicken sandwich, layered with grilled chicken, tomato, lettuce and grilled onions. ", Rate = 3, Price = 430.00 };
            var obj4 = new SandwichModel { SandwichName = "The Real Slim Turkey", SandwichType = "Non-Veg", Ingrediant = "The ultimate Turkey sandwich. Stuffed with Turkey, lettuce, bean sprouts, English cucumber and guacamole.", Rate = 5, Price = 910.00 };
            var obj5 = new SandwichModel { SandwichName = "Lively Tuna", SandwichType = "Non-Veg", Ingrediant = "A blast of flavor with Tuna, tomato, English cucumber and bean sprouts.", Rate = 3, Price = 440.00 };
            var obj6 = new SandwichModel { SandwichName = "Veg Might", SandwichType = "Veg", Ingrediant = "A refreshing variety of creamy avocado, English cucumber, lettuce and tomato.", Rate = 4, Price = 330.00 };
            var obj7 = new SandwichModel { SandwichName = "The Godfather", SandwichType = "Non-Veg", Ingrediant = "A delicious Italian feast for those of you looking to build up. A great combination of pepperoni , salami, onions grilled/raw, lettuce, 2 slices of cheese.", Rate = 4, Price = 450.00 };
            var obj8 = new SandwichModel { SandwichName = "Tuna Might", SandwichType = "Non-Veg", Ingrediant = "An appetizing tortilla filled with a spicy Mexican mixture of your choice of tuna, topped up with gooey cheese.", Rate = 5, Price = 559.99 };
            var obj9 = new SandwichModel { SandwichName = "The Real Slim Beef", SandwichType = "Non-Veg", Ingrediant = "Pulled Beef smothered in BBQ sauce, cheese & grilled onions", Rate = 4, Price = 420.00 };
            var obj10 = new SandwichModel { SandwichName = "Veg Master", SandwichType = "Veg", Ingrediant = "Savor this flavorful combination of paneer/soya served on a bed of lettuce, tomato and cheese, wrapped in a soft taco.", Rate = 4, Price = 590.00 };

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
    }
}
