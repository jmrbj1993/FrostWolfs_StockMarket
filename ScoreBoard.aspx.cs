using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace STMSM
{
    public partial class ScoreBoard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] != null)
            {
                MarketDetails();
                PlayerRanking();
            }
        }

        public void MarketDetails()
        {

           //ScoreBoardDetails s=new ScoreBoardDetails();
           //DataTable dt = s.MarketDetails(Session["UserID"].ToString());
           //RptMarket.DataSource = dt;
           //RptMarket.DataBind();
        }

        public void PlayerRanking()
        {

            ScoreBoardDetails s = new ScoreBoardDetails();
            DataTable dt = s.RankingDetails(Session["UserID"].ToString());
            RptRanking.DataSource = dt;
            RptRanking.DataBind();
        }

        protected void timerRefresh_Tick(object sender, EventArgs e)
        {
            PlayerRanking();

        }
    }
}