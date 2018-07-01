using System;
using MessageBoxControlCenter.MessageBoxes;
using System.Configuration;
using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MetroFramework.Drawing.Html;

namespace PMS.Inventory.InvObjects
{
    public class InvObjectClass
    {
        public string itemCode { get; set; }
        public string itemName { get; set; }
        public string itemDesc { get; set; }
        public string itemGroup { get; set; }       
        public string shelfLife { get; set; }       
        public string warehouse { get; set; }
        public string fromDate { get; set; }
        public string toDate { get; set; }
        public string condition { get; set; }
        public double itemprice { get; set; }
        public string storage { get; set; }
        public int tot { get; set; }
        public int ReorderLvl { get; set; }
        public int RequiredLvl { get; set; }
        public int PurchasedQty { get; set; }
        int result1;



        public void save()
        {
            try
            {
                using (IDbConnection db=new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        DynamicParameters p = new DynamicParameters();
                        p.AddDynamicParams(new {InvCode = itemCode , wCode = warehouse,item =itemName, itemDesc = itemDesc , itemGrp = itemGroup ,
                            life = shelfLife,fromDate = fromDate,toDate= toDate , condition= condition,itemPriz= itemprice,storage = storage
                        });
                        result1 = db.Execute("sp_Inventory_Insert", p, commandType: CommandType.StoredProcedure);
                        //done


                        int result2;
                        DynamicParameters p2 = new DynamicParameters();
                        p2.AddDynamicParams(new
                        {
                            warehouseCode = warehouse,
                            refItemCode=("null"),
                            itemStatus="R",
                            invCode=itemCode,
                            reOrd=ReorderLvl,
                            reqQty=RequiredLvl,
                            purQty=PurchasedQty,
                            availableQty= PurchasedQty,
                            date = fromDate
                        });
                        result2 = db.Execute("sp_Warehouse_transaction_insert", p2, commandType: CommandType.StoredProcedure);
                        if (result2 == 1)
                        {
                            result2 = 1;
                            tot = result1 + result2;
                        }
                        else
                            result2 = 0;
                    }
                }
            }
            catch
            {
                MsgBox.Warning("Cannot be duplicated ,please check your specified id");
            }
        }

        public int update()
        {
            try
            {
                using (IDbConnection db=new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        DynamicParameters updateParam = new DynamicParameters();
                        updateParam.AddDynamicParams(new
                        {
                            code = itemCode,
                            name = itemName,
                            Desc = itemDesc,
                            group = itemGroup,
                            life = shelfLife,
                            house = warehouse,
                            Fdate = fromDate,
                            TDate = toDate,
                            condition = condition,
                            price = itemprice,
                            storage = storage
                        });
                        int line1 = db.Execute("sp_update_inventory", updateParam, commandType: CommandType.StoredProcedure);
                        return line1;
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
