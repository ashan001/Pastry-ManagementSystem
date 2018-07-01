

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pastry_ManagementSystem.DB
{
    public class Database
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataReader dataReader;

        public Database()
        {
            con = new SqlConnection();
            //con.ConnectionString = "Data Source=DESKTOP-AGA9E1P;Initial Catalog=PastryManagementSystem;Persist Security Info=True;User ID=sek001;Password=ashan19960129";
            //===== the following connection string is to my lap (My lap is the server for one user has to create 3 more users)
            //con.ConnectionString = "Data Source=DESKTOP-0SKPCU9\\SQL2016;Initial Catalog=BusBookingSystem;Persist Security Info=True;User ID=AshanPerera;Password=ashan19960129";
            //
            //
            //home pc my personal
            // con.ConnectionString = @"Data Source=DESKTOP-0SKPCU9\SQL2016;Initial Catalog=PastryManagementSystem;Persist Security Info=True;User ID=AshanPerera;Password=ashan19960129";
            //
            //
            //for test area
            //con.ConnectionString = @"Data Source=DESKTOP-0SKPCU9\SQL2016;Initial Catalog=Pastry_Management_System;Integrated Security=True";
            //
            //
            con.ConnectionString = @"Data Source=DESKTOP-BKL3FJL\SQLSERVER2016OBJ;Initial Catalog=Pastry_Management_System;Persist Security Info=True;User ID=sa;Password=ashan19960129";
            //
            //
            //con.ConnectionString = @"Data Source=DESKTOP-AGA9E1P;Initial Catalog=Pastry_Management_System;Integrated Security=True";
        }
        public void openCon()
        {
            con.Open();
        }
        public void closeCon()
        {
            con.Close();
        }

        public SqlDataReader getData(string query)
        {
            try
            {
                openCon();
                cmd = new SqlCommand(query, con);
                dataReader = cmd.ExecuteReader();             
                return dataReader;
              
            }
            catch (SqlException)
            {
                MessageBox.Show("Please check your database connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            closeCon();
            return null;
        }//working fine

        public int returnDBRows(string query)
        {
            int noOfId;
            try
            {
                openCon();
                cmd = new SqlCommand(query, con);
                noOfId = Convert.ToInt32(cmd.ExecuteScalar());               
                return noOfId;
            }
            catch (SqlException)
            {
                MessageBox.Show("Please check your database connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
            closeCon();
            return 0;
        }
        public int update_del_insert_Data(string query)
        {
            int line;
            try
            {
                openCon();
                cmd = new SqlCommand(query, con);
                line = cmd.ExecuteNonQuery();
                closeCon();
                cmd.Dispose();
                return line;
            }
            catch (SqlException)
            {
                MessageBox.Show("Please check your database connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return 0;
        }

        public DataTable sendTable(string sql) {
            try
            {
                openCon();
                SqlDataAdapter da = new SqlDataAdapter(sql,con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (SqlException)
            {

            }
            return null;
        }   
        
             
    }
}
