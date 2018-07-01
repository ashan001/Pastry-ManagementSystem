using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastry_ManagementSystem.Other
{
    public class ProductData
    {
        public string reference_No { get; set; }
        public string cus_id { get; set; }
        public string ord_Id { get; set; }
        public string food_Name { get; set; }
        public string OrdDate { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
        public double tot_Amt { get; set; }
    }
    public class TakeProductData
    {
        public string reference_No { get; set; }
        public string cus_id { get; set; }
        public string ord_Id { get; set; }
        public string food_Name { get; set; }
        public string OrdDate { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
        public double tot_Amt { get; set; }
    }
}
