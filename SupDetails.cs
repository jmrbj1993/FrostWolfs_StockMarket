using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace STMSM
{
    public class SupDetails
    {
        public Boolean SignUpUserDetails(String UserID, string pawd)
        {
            connection conClass = new connection();
            try
            {
                conClass.ReadConnection();
                conClass.Con.Open();
                SqlCommand cmd = new SqlCommand("SignUPUser", conClass.Con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = UserID;
                cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = pawd;


                cmd.ExecuteNonQuery();
                conClass.Con.Close();
                return true;
            }
            catch
            {
                return false;

            }
            finally
            {


            }


        }
    }
}