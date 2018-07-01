using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
//
using Dapper;//db library
//
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastry_ManagementSystem.ExtraClassesToMapData
{
    public class ObjectsOfIssueForm
    {
        public string ItemCode { get; set; }
        public string WarehouseCode { get; set; }
        public string Type { get; set; } = "ISSUE";
        public int Quantity { get; set; }
  



        public int save()
        {
            try
            {
                using (IDbConnection db=new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        DynamicParameters p = new DynamicParameters();
                        p.AddDynamicParams(new {
                            itemCode = ItemCode,
                            warehouseCode = WarehouseCode,
                            transactionType = Type,
                            Qty = Quantity,
                            date = DateTime.Now.Date.ToShortDateString()
                        });
                        int res = db.Execute("sp_transaction_insert", p,commandType:CommandType.StoredProcedure);//working
                        //return res;
                        //
                        //
                        DynamicParameters p2 = new DynamicParameters();
                        p2.AddDynamicParams(new
                        {
                            itemCode=ItemCode,
                            AvailableQty=Quantity
                        });
                        int res2 = db.Execute("sp_updateWT_From_Issue", p2, commandType: CommandType.StoredProcedure);
                        //
                        return (res + res2);
                    }
                }
            }
            catch
            {
                throw;
            }
            return 0;
        }
    }
}
