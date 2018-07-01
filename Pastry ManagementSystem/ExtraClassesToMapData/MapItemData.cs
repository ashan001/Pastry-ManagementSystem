using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using Dapper;
//
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessageBoxControlCenter.MessageBoxes;

namespace Pastry_ManagementSystem.ExtraClassesToMapData
{
    public class MapItemData
    {
        public string itemID { get; set; }
      //  public int ReferenceitemID { get; set; }
        public string EmployeeID { get; set; }
        public string WarehouseCode { get; set; }
        public string ItemName { get; set; }
        public string ItemType { get; set; }
        public string ItemDesc { get; set; }
        public string DateTime { get; set; }
        public string BatchID { get; set; }
        public string ManifacturingDate { get; set; }
        public string ExpireDate { get; set; }
        public double PurchasePrice { get; set; }
        public double CashInWoleSale { get; set; }
        public double VatPercentage { get; set; }
        public double VatAmount { get; set; }
        public int TotalPurchase { get; set; }
        public int TotalQuantity { get; set; }
        public double NetAmount { get; set; }
        public string warehouse_code;
        public int availableQty { get; set; }
        public int requiredQty { get; set; }
        public int ReOrderLvl { get;  set; }

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
                            id=itemID,
                            empID= EmployeeID,
                            warehouseCode= WarehouseCode,
                            itemName= ItemName,
                            itemType= ItemType,
                            itemDesc=ItemDesc,
                            dateTime= DateTime,
                            batchNo= BatchID,
                            mfgDate= ManifacturingDate,
                            expDate= ExpireDate,
                            purchasePrice= PurchasePrice,
                            cashWoleSale= CashInWoleSale,
                            vatPerc= VatPercentage,
                            vatAmt= VatAmount,
                            totPur= TotalPurchase,
                            totQty= TotalQuantity,
                            netAmt= NetAmount
                        });
                        result= db.Execute("sp_Insert_itemFile_Data", p,commandType:CommandType.StoredProcedure);
                    }
                    return result;
                }
            }
            catch
            {
                throw;
            }
        }
        int line,line2,tot;
        public int update()
        {
            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        DynamicParameters p3 = new DynamicParameters();
                        p3.AddDynamicParams(new
                        {
                            id = itemID,
                            itemName = ItemName,
                            batchNo = BatchID,
                            itemType = ItemType,
                            itemDesc = ItemDesc,
                            dateTime = DateTime,
                            purchasePrice = PurchasePrice,
                            cashWoleSale = CashInWoleSale,
                            vatPerc = VatPercentage,
                            vatAmt = VatAmount
                        });
                       int line= db.Execute("sp_item_File_update", p3,commandType:CommandType.StoredProcedure);
                        return line;
                    }
                }
            }
            catch
            {
                throw;
            }
            return 0;
        }
        public int select()
        {
            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string sql = $"Select Count (ItemID) From Item_File where ItemID='{itemID}'";
                        int x = db.ExecuteScalar<int>(sql);
                        return x;
                    }
                }
            }
            catch (Exception ex)
            {
                MsgBox.Exception(ex);
            }
            return 0;
        }
    }
}
