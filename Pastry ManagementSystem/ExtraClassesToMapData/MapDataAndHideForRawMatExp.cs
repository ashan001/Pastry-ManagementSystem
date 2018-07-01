using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastry_ManagementSystem.ExtraClassesToMapData
{
    public class MapDataAndHideForRawMatExp
    {
        public string receipt_No { get; set; }
        public string item_name { get; set; }
        public DateTime date_received { get; set; }
        public string supp_ID { get; set; }
        public string company_Name { get; set; }
        public string item_id { get; set; }
        public double item_price { get; set; }
        public double total_amount { get; set; }
        public int quantity { get; set; }
    }
}
