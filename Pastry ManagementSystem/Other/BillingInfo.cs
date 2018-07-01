using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastry_ManagementSystem.Other
{
    public class BillingInfo
    {
        public string food_no { get; set; }
        public string Food_Name { get; set; }       
        public double price { get; set; }      
        public double total_Price { get; set; }
        public double qty
        {
            get
            {
                return total_Price / price;
            }
        }
    }
}
