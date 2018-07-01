using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastry_ManagementSystem.Other
{
    public class DailyIncomeClass
    {
        public string bill_no { get; set; }
        public string _empID { get; set; }
        public int food_no { get; set; }
        public double sub_total { get; set; }
        public double bill_gst { get; set; }
        public double bill_tot { get; set; }

    }
}
