using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.AdminPanel.ExtraClasses
{
    public class LoginObject
    {
        public string UserName { get; set; }
        public string EmployeeID { get; set; }
        public string Email { get; set; }
        public string  EmployeeRole { get; set; }
        public string Password { get; set; }

        public int AvoidDuplicateUserName()
        {
            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string sql = $"Select Count(userName)From Emp_Login where userName='{UserName}';";
                        int value = db.ExecuteScalar<int>(sql);
                        return value;                       
                    }
                }
            }
            catch
            {
                throw;
            }
            return 0;
        }

        public int save()
        {

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                    DynamicParameters p = new DynamicParameters();
                    p.AddDynamicParams(new
                    {
                        empID = EmployeeID,
                        usrName = UserName,
                        usrPass = Password                        
                    });
                    int result = db.Execute("sp_Emp_Login_insert", p, commandType: CommandType.StoredProcedure);
                    return result;
                }
            }
       
            return 0;
        }
    }
}
