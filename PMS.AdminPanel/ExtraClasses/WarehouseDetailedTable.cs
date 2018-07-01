using System;
using System.Data;
using System.Configuration;
using Dapper;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.AdminPanel.ExtraClasses
{
   public class WarehouseDetailedTable
    {
        public string warehouse_code { get; set; }
        public string Warehouse_description { get; set; }
        public string warehouseStatus { get; set; }

        public int result;
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
                        p.AddDynamicParams(new {
                            code= warehouse_code,
                            desc= Warehouse_description,
                            status= warehouseStatus
                        });
                        result = db.Execute("sp_warehouse_master_insert", p, commandType: CommandType.StoredProcedure);
                        if (result != 0)
                        {
                            result = 1;
                        }
                        else
                            result = 0;
                    }
                }
            }
            catch
            {
                throw;
            }
        }
        public void update()
        {
            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        DynamicParameters p = new DynamicParameters();
                        p.AddDynamicParams(new
                        {
                            code = warehouse_code,
                            desc = Warehouse_description,
                            status = warehouseStatus
                        });
                        result = db.Execute("sp_sp_warehouse_master_update", p, commandType: CommandType.StoredProcedure);
                        if (result != 0)
                        {
                            result = 1;
                        }
                        else
                            result = 0;
                    }
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
