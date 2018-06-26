using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace STMSM
{
    public class LDetails
    {
        public DataTable CheckLogin(string Uname, string pwd)
        {
            connection conClass = new connection();
            string conString;
            DataTable dt = new DataTable();
            try
            {
                conClass.ReadConnection();
                conClass.Con.Open();
                SqlCommand cmd = new SqlCommand("CheckLogin", conClass.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Uname", SqlDbType.VarChar).Value = Uname;
                cmd.Parameters.Add("@Pwd", SqlDbType.VarChar).Value = pwd;
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

        public DataTable ExecuteOrder(string UserID)
        {
            connection conClass = new connection();
            string conString;
            DataTable dt = new DataTable();
            try
            {
                conClass.ReadConnection();
                conClass.Con.Open();
                SqlCommand cmd = new SqlCommand("spExecuteOrder", conClass.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@UserID", SqlDbType.VarChar).Value = UserID;
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

        public Boolean InsertValues(String PlayerName,string UserID)
        {
            connection conClass = new connection();
            try
            {
                conClass.ReadConnection();
                conClass.Con.Open();
                SqlCommand cmd = new SqlCommand("InsertCurrentPlayers", conClass.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.Add("@PlayerName", SqlDbType.VarChar).Value = PlayerName;
                cmd.Parameters.Add("@UserID", SqlDbType.VarChar).Value = UserID;
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

        public Boolean DeletePcPlayerValues()
        {
            connection conClass = new connection();
            try
            {
                conClass.ReadConnection();
                conClass.Con.Open();
                SqlCommand cmd = new SqlCommand("PcPlayerRoundDelete", conClass.Con);
                cmd.CommandType = CommandType.StoredProcedure;

                
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


        public Boolean InserUserMarkettValues(String UserID)
        {
            connection conClass = new connection();
            try
            {
                conClass.ReadConnection();
                conClass.Con.Open();
                SqlCommand cmd = new SqlCommand("UserMarketDetails", conClass.Con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@UserID", SqlDbType.VarChar).Value = UserID;
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

        public Boolean InsertBankBalance(String UserID)
        {
            connection conClass = new connection();
            try
            {
                conClass.ReadConnection();
                conClass.Con.Open();
                SqlCommand cmd = new SqlCommand("InserBankBalance", conClass.Con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@UserID", SqlDbType.VarChar).Value = UserID;
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

        public Boolean InsertPlayerRound(String UserID)
        {
            connection conClass = new connection();
            try
            {
                conClass.ReadConnection();
                conClass.Con.Open();
                SqlCommand cmd = new SqlCommand("UserPlayRound", conClass.Con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@UserID", SqlDbType.VarChar).Value = UserID;
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
        
        public Boolean ClearHistory(String UserID)
        {
            connection conClass = new connection();
            try
            {
                conClass.ReadConnection();
                conClass.Con.Open();
                SqlCommand cmd = new SqlCommand("ClearHistoty", conClass.Con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@UserID", SqlDbType.VarChar).Value = UserID;
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

        public Boolean ClearTempCurrentPlayers(String UserID)
        {
            connection conClass = new connection();
            try
            {
                conClass.ReadConnection();
                conClass.Con.Open();
                SqlCommand cmd = new SqlCommand("ClearTempCurrentPlayers", conClass.Con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@UserID", SqlDbType.VarChar).Value = UserID;
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
        public Boolean EventOccurCompanySetup()
        {
            connection conClass = new connection();
            try
            {
                conClass.ReadConnection();
                conClass.Con.Open();
                SqlCommand cmd = new SqlCommand("EventOccurCompanySetup", conClass.Con);
                cmd.CommandType = CommandType.StoredProcedure;

                
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

        public Boolean ClearCP(string UserID)
        {
            connection conClass = new connection();
            try
            {
                conClass.ReadConnection();
                conClass.Con.Open();
                SqlCommand cmd = new SqlCommand("ClearCurrentPlayer", conClass.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@UserID", SqlDbType.VarChar).Value = UserID;

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

        public Boolean EventOccurSectorSetup()
        {
            connection conClass = new connection();
            try
            {
                conClass.ReadConnection();
                conClass.Con.Open();
                SqlCommand cmd = new SqlCommand("EventOccurSectorSetup", conClass.Con);
                cmd.CommandType = CommandType.StoredProcedure;


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