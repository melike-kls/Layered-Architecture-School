using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Data Access Layer
namespace DAL
{
    public class Helper
    {
        public int ExecuteNonQuery(string cmdtext)
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString);
                SqlCommand cmd = new SqlCommand(cmdtext, cn);
                cn.Open();
                int sonuc = cmd.ExecuteNonQuery();
                cn.Close();
                return sonuc;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public SqlDataReader ExecuteReader(string cmdtext)
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString);
                SqlCommand cmd = new SqlCommand(cmdtext, cn);
                cn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
