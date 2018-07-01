using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastry_ManagementSystem.Other
{
    public class ItemClass
    {
        public string ItemID { get; set; }
        public string empID { get; set; }
        public string Item_Name { get; set; }
        public string warehouseCode { get; set; }
        public int AvailableQty { get; set; }
        public double purchase_price { get; set; }
        public double Vat_Amt { get; set; }
        public int tot_purchases { get; set; }
        public double net_Amt { get; set; }
    }
    public class MapItemData
    {
        public string ItemID { get; set; }
        public string empID { get; set; }
        public string Item_Name { get; set; }
        public int AvailableQty { get; set; }
        public double purchase_price { get; set; }
        public double Vat_Amt { get; set; }
        public int tot_purchases { get; set; }
        public double net_Amt { get; set; }
        public double unitPrice
        {
            get
            {
                return net_Amt / AvailableQty;
            }
        }
    }
}
