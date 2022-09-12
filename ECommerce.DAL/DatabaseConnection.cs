using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ECommerce.DAL
{
    public class DatabaseConnection
    {
        SqlConnection sqlConn;
        public DatabaseConnection()
        {
            sqlConn = new SqlConnection("Data Source =.\\sqlexpress; Initial catalog = Ecommerce; Integrated Security=True");
        }
        /// <summary>
        /// It executes insert, update and delete query and returns number of row affected
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public int ExecuteQuery(string query)
        {
            SqlCommand sqlCommand = new SqlCommand(query, sqlConn);
            try
            {
                sqlCommand.Connection.Open();
                return sqlCommand.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlCommand.Connection.Close();
            }
        }
        public DataTable GetData(string query)
        {
            DataTable dt = new DataTable(); 
        }
    }
}
