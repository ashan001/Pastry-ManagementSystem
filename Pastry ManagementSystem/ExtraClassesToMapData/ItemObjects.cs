using MessageBoxControlCenter.MessageBoxes;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastry_ManagementSystem.ExtraClassesToMapData
{
    public class ItemObjects
    {
        //warehouse Obj
        public string warehouse_code { get; set; }
        public string ReferenceItemCode { get; set; }
        public string ItemStatus { get; set; }
        public string InvCode { get; set; }
        public int availableQty { get; set; }
        public int ReOrderLvl { get; set; }
        public int requiredQty { get; set; }
        public int purchasedQty { get; set; }
        public DateTime date { get; set; }


        int result;
        public int save()
        {
            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        DynamicParameters p = new DynamicParameters();
                        p.AddDynamicParams(new {
                            warehouseCode = warehouse_code,
                            refItemCode = ReferenceItemCode,
                            itemStatus= ItemStatus,
                            invCode= InvCode,
                            reOrd = ReOrderLvl,
                            reqQty = requiredQty,
                            purQty = purchasedQty,
                            availableQty = availableQty,
                            date = date
                        });
                        result = db.Execute("sp_Warehouse_transaction_insert", p, commandType: CommandType.StoredProcedure);
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                MsgBox.Exception(ex);
            }
            return 0;
        }
        public int update()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                    DynamicParameters updateParam = new DynamicParameters();
                    updateParam.AddDynamicParams(new
                    {
                        itemCode=ReferenceItemCode,
                        purchQty=purchasedQty
                    });
                    int res = db.Execute("sp_updateWarehouseTransactin_avaQty", updateParam, commandType: CommandType.StoredProcedure);
                    return res;
                }
            }
            return 0;
        }       
    }
}
