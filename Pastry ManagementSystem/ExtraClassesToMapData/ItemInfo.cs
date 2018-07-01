using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastry_ManagementSystem.ExtraClassesToMapData
{
    public class ItemInfo
    {
        public string ItemID { get; set; }
        public string Item_Name { get; set; }
        public string item_Desc { get; set; }
        public string batch_No { get; set; }
        public double purchase_price { get; set; }
        public string warehouseCode { get; set; }
        public double tot_purchases { get; set; }
     
        public double ItemPrice
        {
            get
            {
                return (purchase_price/ tot_purchases);
            }
        }
    }
}
