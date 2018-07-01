using System;
using System.Data;
using System.Configuration;
using Dapper;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessageBoxControlCenter.MessageBoxes;
using Pastry_ManagementSystem.UI.HelpScreens;

namespace Pastry_ManagementSystem.ExtraClassesToMapData
{
    public class WarehouseInfo
    {
        public string warehouse_code { get; set; }
        public string Warehouse_description { get; set; }
        public string warehouseStatus { get; set; }
      
    }
}
