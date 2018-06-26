using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace STMSM
{
    public class HistoryD
    {
        public DataTable MarketDetails(string userID)
        {
            connection conClass = new connection();
            string conString;
            DataTable dt = new DataTable();
            try
            {
                conClass.ReadConnection();
                conClass.Con.Open();
                SqlCommand cmd = new SqlCommand("HistoryDetails", conClass.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@UserID", SqlDbType.VarChar).Value = userID;
                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                adp.Fill(dt);
                cmd.ExecuteNonQuery();
                return dt;
            }
            catch
            {

                return dt;
            }
            finally
            {
                conClass.Con.Close();
            }

        }
    }
}