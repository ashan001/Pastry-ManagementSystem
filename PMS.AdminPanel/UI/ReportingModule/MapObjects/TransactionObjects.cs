using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.AdminPanel.UI.ReportingModule.MapObjects
{
    public class TransactionObjects
    {
        public string TransactionReference { get; set; }
        public string itemCode { get; set; }
        public string warehouseCode { get; set; }
        public string TransactionType { get; set; }
        public int quantity { get; set; }
        public string Item_Name { get; set; }

    }
}
