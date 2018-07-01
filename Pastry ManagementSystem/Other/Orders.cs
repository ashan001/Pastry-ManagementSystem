using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pastry_ManagementSystem.Other
{
    public  class Orders
    {
        public string order_No { get; set; }
        public string order_Date { get; set; }
        public string cusID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ContactNum { get; set; }
        public string cus_address { get; set; }
        public string NIC { get; set; }
    }    
}
