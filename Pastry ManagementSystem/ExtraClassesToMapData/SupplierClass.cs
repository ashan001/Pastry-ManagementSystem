using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastry_ManagementSystem.ExtraClassesToMapData
{
    public class SupplierClass
    {
        public string supp_ID { get; set; }
        public string supp_FirstName { get; set; }
        public string supp_lastName { get; set; }
        public string company_Name { get; set; }
        public string company_Address { get; set; }
        public string contactNumber { get; set; }
        public string NIC { get; set; }
        public string emailAddress { get; set; }
        public DateTime RegisteredDate { get; set; }
        public int fax_Num { get; set; }
        public string web_siteName { get; set; }
        public string Comments { get; set; }
    }
}
