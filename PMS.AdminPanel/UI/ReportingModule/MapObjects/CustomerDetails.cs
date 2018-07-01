using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.AdminPanel.UI.ReportingModule.MapObjects
{
    public class CustomerDetails
    {
        public string cusID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ContactNum { get; set; }
        public string cus_address { get; set; }
        public string regDate { get; set; }
        public int quantity { get; set; }
        public double totAmt { get; set; }
        public string OrderedTimes_Flag { get; set; }
    }
}
