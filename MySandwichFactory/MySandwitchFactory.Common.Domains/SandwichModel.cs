using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySandwitchFactory.Common.Domains
{
    public class SandwichModel
    {
        public string SandwichName { get; set; }
        public string SandwichType { get; set; }
        public string Ingrediant { get; set; }
        public int Rate { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
    }
    
}
