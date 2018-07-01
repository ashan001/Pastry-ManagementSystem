using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastry_ManagementSystem.ExtraClassesToMapData
{
   public  class InvetoryInfo
    {
        public string InvITemCode { get; set; }
        public string itemName { get; set; }
        public string reOrdeLvl { get; set; }
        public string required_lvl { get; set; }
        public string AvailableQty { get; set; }
        public string warehouseCode { get; set; }

    }
}
