using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySandwitchFactory.Web.UI
{
    public class SandwichViewModel
    {
        public string SandwichName { get; set; }
        public string SandwichType { get; set; }
        public string Ingrediant { get; set; }
        public int Rate { get; set; }
        public double Price { get; set; }

    }
}
