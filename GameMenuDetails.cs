using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace STMSM
{
    public class GameMenuDetails
    {
        public DataTable CurrentPlayers()
        {
            connection conClass = new connection();
            string conString;
            DataTable dt = new DataTable();
            try
            {
                conClass.ReadConnection();
                conClass.Con.Open();
                SqlCommand cmd = new SqlCommand("CurrentPlayerCount", conClass.Con);
                cmd.CommandType = CommandType.StoredProcedure;

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

        public DataTable GetBankBalance(string userID)
        {
            connection conClass = new connection();
            string conString;
            DataTable dt = new DataTable();
            try
            {
                conClass.ReadConnection();
                conClass.Con.Open();
                SqlCommand cmd = new SqlCommand("getBankBalanceUser", conClass.Con);
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

        public DataTable GetPlayRound(string userID)
        {
            connection conClass = new connection();
            string conString;
            DataTable dt = new DataTable();
            try
            {
                conClass.ReadConnection();
                conClass.Con.Open();
                SqlCommand cmd = new SqlCommand("UserSearchPlayRound", conClass.Con);
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

        public DataTable GetChartDetails()
        {
            connection conClass = new connection();
            string conString;
            DataTable dt = new DataTable();
            try
            {
                conClass.ReadConnection();
                conClass.Con.Open();
                SqlCommand cmd = new SqlCommand("ChartController", conClass.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                
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
        public DataTable MarketDetails(string userID)
        {
            connection conClass = new connection();
            string conString;
            DataTable dt = new DataTable();
            try
            {
                conClass.ReadConnection();
                conClass.Con.Open();
                SqlCommand cmd = new SqlCommand("MarketDetails", conClass.Con);
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

        public DataTable MarketDetailsSectionWise(string value,string userID)
        {
            connection conClass = new connection();
            string conString;
            DataTable dt = new DataTable();
            try
            {
                conClass.ReadConnection();
                conClass.Con.Open();
                SqlCommand cmd = new SqlCommand("MarketDetailsSectionWise", conClass.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@SectorID", SqlDbType.VarChar).Value = value;
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
        
        public DataTable MarketPriceAndOthers(string Sector,string Company,string userID)
        {
            connection conClass = new connection();
            string conString;
            DataTable dt = new DataTable();
            try
            {
                conClass.ReadConnection();
                conClass.Con.Open();
                SqlCommand cmd = new SqlCommand("MarketPriceDetails", conClass.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Sector", SqlDbType.VarChar).Value = Sector;
                cmd.Parameters.Add("@Company", SqlDbType.VarChar).Value = Company;
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

        public DataTable CheckEventOccurCompany(string roundID)
        {
            connection conClass = new connection();
            string conString;
            DataTable dt = new DataTable();
            try
            {
                conClass.ReadConnection();
                conClass.Con.Open();
                SqlCommand cmd = new SqlCommand("CheckEventOccurCompanyRound", conClass.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@RoundID", SqlDbType.VarChar).Value = roundID;
                
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

        public DataTable CheckEventOccurSector(string roundID)
        {
            connection conClass = new connection();
            string conString;
            DataTable dt = new DataTable();
            try
            {
                conClass.ReadConnection();
                conClass.Con.Open();
                SqlCommand cmd = new SqlCommand("CheckEventOccurSectorRound", conClass.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@RoundID", SqlDbType.VarChar).Value = roundID;

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

         public DataTable MarketPricePageLoad(string userID)
        {
            connection conClass = new connection();
            string conString;
            DataTable dt = new DataTable();
            try
            {
                conClass.ReadConnection();
                conClass.Con.Open();
                SqlCommand cmd = new SqlCommand("CalPageLoadPricePerShare", conClass.Con);
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
         public DataTable SelecTime()
         {
             connection conClass = new connection();
             string conString;
             DataTable dt = new DataTable();
             try
             {
                 conClass.ReadConnection();
                 conClass.Con.Open();
                 SqlCommand cmd = new SqlCommand("SelecTime", conClass.Con);
                 cmd.CommandType = CommandType.StoredProcedure;

                 
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
         public bool UpdateTime()
         {
             connection conClass = new connection();
             string conString;
             DataTable dt = new DataTable();
             try
             {
                 conClass.ReadConnection();
                 conClass.Con.Open();
                 SqlCommand cmd = new SqlCommand("UpdateTime", conClass.Con);
                 cmd.CommandType = CommandType.StoredProcedure;


                 SqlDataAdapter adp = new SqlDataAdapter(cmd);

                 adp.Fill(dt);
                 cmd.ExecuteNonQuery();
                 return true;
             }
             catch
             {

                 return false;
             }
             finally
             {
                 conClass.Con.Close();
             }

         }
         public bool SetTime()
         {
             connection conClass = new connection();
             string conString;
             DataTable dt = new DataTable();
             try
             {
                 conClass.ReadConnection();
                 conClass.Con.Open();
                 SqlCommand cmd = new SqlCommand("SetTime", conClass.Con);
                 cmd.CommandType = CommandType.StoredProcedure;


                 SqlDataAdapter adp = new SqlDataAdapter(cmd);

                 adp.Fill(dt);
                 cmd.ExecuteNonQuery();
                 return true;
             }
             catch
             {

                 return false;
             }
             finally
             {
                 conClass.Con.Close();
             }

         }

         public bool ExecutePCPlayer()
         {
             connection conClass = new connection();
             string conString;
             DataTable dt = new DataTable();
             try
             {
                 conClass.ReadConnection();
                 conClass.Con.Open();
                 SqlCommand cmd = new SqlCommand("PCPlayerSp", conClass.Con);
                 cmd.CommandType = CommandType.StoredProcedure;


                 SqlDataAdapter adp = new SqlDataAdapter(cmd);

                 adp.Fill(dt);
                 cmd.ExecuteNonQuery();
                 return true;
             }
             catch
             {

                 return false;
             }
             finally
             {
                 conClass.Con.Close();
             }

         }
        public Boolean BuyShare(string share,double value, String UserID,string sectorID,string companyID)
        {
            connection conClass = new connection();
            try
            {
                conClass.ReadConnection();
                conClass.Con.Open();
                SqlCommand cmd = new SqlCommand("buyShare", conClass.Con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Share", SqlDbType.VarChar).Value = share;
                cmd.Parameters.Add("@Value", SqlDbType.VarChar).Value = value;
                cmd.Parameters.Add("@UserID", SqlDbType.VarChar).Value = UserID;
                cmd.Parameters.Add("@SectorID", SqlDbType.VarChar).Value = sectorID;
                cmd.Parameters.Add("@ComapnyID", SqlDbType.VarChar).Value = companyID;

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

        public Boolean UpdatePLayerRound( String UserID)
        {
            connection conClass = new connection();
            try
            {
                conClass.ReadConnection();
                conClass.Con.Open();
                SqlCommand cmd = new SqlCommand("UserUpdatePlayRound", conClass.Con);
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

        public Boolean TempCurrentPlayers(String UserID)
        {
            connection conClass = new connection();
            try
            {
                conClass.ReadConnection();
                conClass.Con.Open();
                SqlCommand cmd = new SqlCommand("AccTempCurrentPlayer", conClass.Con);
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

        public Boolean BasicValueChange()
        {
            connection conClass = new connection();
            try
            {
                conClass.ReadConnection();
                conClass.Con.Open();
                SqlCommand cmd = new SqlCommand("BasicValueChangeAlgorithm", conClass.Con);
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
        public Boolean ExecuteEventOccurCompany(string CompnayID,string RoundID)
        {
            connection conClass = new connection();
            try
            {
                conClass.ReadConnection();
                conClass.Con.Open();
                SqlCommand cmd = new SqlCommand("ExecuteEventCompanyOccur", conClass.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CompanyID", SqlDbType.VarChar).Value = CompnayID;
                cmd.Parameters.Add("@RoundID", SqlDbType.VarChar).Value = @RoundID;


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

        public Boolean ExecuteEventOccurSector(string SectorID, string RoundID)
        {
            connection conClass = new connection();
            try
            {
                conClass.ReadConnection();
                conClass.Con.Open();
                SqlCommand cmd = new SqlCommand("ExecuteEventSectorOccur", conClass.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@SectorID", SqlDbType.VarChar).Value = SectorID;
                cmd.Parameters.Add("@RoundID", SqlDbType.VarChar).Value = RoundID;

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

        public Boolean SignOut(String UserID)
        {
            connection conClass = new connection();
            try
            {
                conClass.ReadConnection();
                conClass.Con.Open();
                SqlCommand cmd = new SqlCommand("SignOut", conClass.Con);
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

        public Boolean SellShare(string share, double value, String UserID, string sectorID, string companyID)
        {
            connection conClass = new connection();
            try
            {
                conClass.ReadConnection();
                conClass.Con.Open();
                SqlCommand cmd = new SqlCommand("SellShare", conClass.Con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Share", SqlDbType.VarChar).Value = share;
                cmd.Parameters.Add("@Value", SqlDbType.VarChar).Value = value;
                cmd.Parameters.Add("@UserID", SqlDbType.VarChar).Value = UserID;
                cmd.Parameters.Add("@SectorID", SqlDbType.VarChar).Value = sectorID;
                cmd.Parameters.Add("@ComapnyID", SqlDbType.VarChar).Value = companyID;

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

        public DataTable CheckShare(String UserID, string sectorID, string companyID)
        {
            connection conClass = new connection();
            DataTable dt = new DataTable();
            try
            {
                conClass.ReadConnection();
                conClass.Con.Open();
                SqlCommand cmd = new SqlCommand("SelectShare", conClass.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@UserID", SqlDbType.VarChar).Value = UserID;
                cmd.Parameters.Add("@SectorID", SqlDbType.VarChar).Value = sectorID;
                cmd.Parameters.Add("@ComapnyID", SqlDbType.VarChar).Value = companyID;

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


            }


        }
    }
}