using System;
using System.Data;
using System.Collections.Generic;
using System.Configuration;
using Dapper;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.AdminPanel.ExtraClasses.ChangePassword;

namespace PMS.AdminPanel.ExtraClasses
{
   public class CheckUser
    {
        Prop obj = new Prop();
        DbValues obj2 = new DbValues();
        public int flagged { get; set; }
        public void ChkUser()
        {
            try
            {
                using (IDbConnection db=new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string sql = $"Select * From Emp_Login where userName='{obj.userName}'";
                        // DbValues obj2 = db.Query<DbValues>(sql,commandType:CommandType.Text).SingleOrDefault();
                        //if (obj.user_email == obj2.user_email)
                        //{
                        //    flagged ++;
                        //}
                        IDataReader reader = db.ExecuteReader(sql);
                        while (reader.Read())
                        {
                            obj2.userName = reader["userName"].ToString();                           
                            break;
                        }
                        if (obj.userName == obj2.userName)
                        {
                            flagged = 1;
                        }
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
