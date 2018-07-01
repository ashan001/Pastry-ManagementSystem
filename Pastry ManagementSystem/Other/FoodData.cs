using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastry_ManagementSystem.Other
{
    public class FoodData
    {
        public string order_No { get; set; }
        public string cus_No { get; set; }
        public string Due_Date { get; set; }
        public string Due_Time { get; set; }
        public string foodName { get; set; }
        public double item_price { get; set; }
        public int quantity { get; set; }
        public double totAmt { get; set; }
    }
}
