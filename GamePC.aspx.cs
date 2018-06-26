using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.UI.DataVisualization.Charting;

namespace STMSM
{
    public partial class GamePC : System.Web.UI.Page
    {
        int Chances = 0;
        double Balance = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Session["UserID"] != null)
                {
                    Session["CountID"] = 10;
                    getBankBalance();
                    GameMenuDetails gm = new GameMenuDetails();
                    DataTable dt = new DataTable();
                    dt = gm.CurrentPlayers();
                    int RowCount = dt.Rows.Count;

                    if (RowCount == 2)
                    {

                        //TextBox1.Visible = false;

                    }
                    MarketDetails();
                    Perform();
                    ddlSector1.SelectedIndex = 1;
                    ddlCompany1.SelectedIndex = 1;
                    txtNumberOFbyes.Text = "0";
                    txtTotalPrice.Text = "00.00";
                    ddlSector1.SelectedIndex = 0;
                    ddlCompany1.SelectedIndex = 0;
                    PerformOnBasicLoad();
                    
                }
                else
                {
                    Response.Redirect("Login.aspx");

                }
            }
            else
            {


            }

        }

        public void getBankBalance()
        {
            GameMenuDetails gm = new GameMenuDetails();
            DataTable dt = new DataTable();
            dt = gm.GetBankBalance(Session["UserID"].ToString());


            DataTable dt1 = new DataTable();
            dt1 = gm.GetPlayRound(Session["UserID"].ToString());

            NavUserChance.InnerText = "Round -" + dt1.Rows[0][0].ToString();

            NavUSer.InnerText = "User -" + Session["UserName"].ToString();

            NavBalance.InnerText = dt.Rows[0][0].ToString();

        }

        public void PlayRoundCheck()
        {
            GameMenuDetails gm = new GameMenuDetails();
            DataTable dt1 = new DataTable();
            dt1 = gm.GetPlayRound(Session["UserID"].ToString());
            NavUserChance.InnerText = "Round -" + dt1.Rows[0][0].ToString();
        }

        public void PerformOnBasicLoad()
        {
            GameMenuDetails gm = new GameMenuDetails();
            DataTable dt = new DataTable();
            dt = gm.MarketPricePageLoad(Session["UserID"].ToString());

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                txtPriceperShare.Text = dt.Rows[i][0].ToString();


            }

        }

        public void Perform()
        {
            GameMenuDetails gm = new GameMenuDetails();
            DataTable dt = new DataTable();
            dt = gm.MarketPriceAndOthers(ddlSector1.SelectedValue.ToString(), ddlCompany1.SelectedValue.ToString(), Session["UserID"].ToString());

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                txtPriceperShare.Text = dt.Rows[i][0].ToString();


            }

        }
        public void MarketDetails()
        {
            GameMenuDetails gm = new GameMenuDetails();
            DataTable dt = new DataTable();
            dt = gm.MarketDetails(Session["UserID"].ToString());
            RptMarket.DataSource = dt.DefaultView;
            RptMarket.DataBind();

            //gridMarket.DataSource = dt.DefaultView;
            //gridMarket.DataBind();
        }

        protected void ddlSector_SelectedIndexChanged(object sender, EventArgs e)
        {
            GameMenuDetails gm = new GameMenuDetails();
            DataTable dt = new DataTable();
            dt = gm.MarketDetailsSectionWise(ddlSector.SelectedValue.ToString(), Session["UserID"].ToString());
            RptMarket.DataSource = dt.DefaultView;
            RptMarket.DataBind();

        }

        protected void ddlSector1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTotalPrice.Text = "0.00";
            txtNumberOFbyes.Text = "0";

            GameMenuDetails gm = new GameMenuDetails();
            DataTable dt = new DataTable();
            dt = gm.MarketPriceAndOthers(ddlSector1.SelectedValue.ToString(), ddlCompany1.SelectedValue.ToString(), Session["UserID"].ToString());

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                txtPriceperShare.Text = dt.Rows[i][0].ToString();

            }

        }

        protected void ddlCompany1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTotalPrice.Text = "0.00";
            txtNumberOFbyes.Text = "0";
            GameMenuDetails gm = new GameMenuDetails();
            DataTable dt = new DataTable();
            dt = gm.MarketPriceAndOthers(ddlSector1.SelectedValue.ToString(), ddlCompany1.SelectedValue.ToString(), Session["UserID"].ToString());

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                txtPriceperShare.Text = dt.Rows[i][0].ToString();


            }
        }

        protected void txtNumberOFbyes_TextChanged(object sender, EventArgs e)
        {
            try
            {


                GameMenuDetails gm = new GameMenuDetails();
                DataTable dt = new DataTable();
                dt = gm.MarketPriceAndOthers(ddlSector1.SelectedValue.ToString(), ddlCompany1.SelectedValue.ToString(), Session["UserID"].ToString());

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    txtPriceperShare.Text = dt.Rows[i][0].ToString();

                }
                Double value = Convert.ToDouble(txtNumberOFbyes.Text) * Convert.ToDouble(txtPriceperShare.Text);
                txtTotalPrice.Text = value.ToString();
                lblErorMessage.InnerText = "";


            }
            catch (Exception ex)
            {

            }
        }

        protected void btnBye_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtNumberOFbyes.Text) * Convert.ToDouble(txtPriceperShare.Text) > Convert.ToDouble(NavBalance.InnerHtml.ToString()))
            {
                lblErorMessage.InnerText = "Insuffiecent Balance";
                txtTotalPrice.Text = "0.00";
            }
            else
            {
                if (txtNumberOFbyes.Text == "0" || txtNumberOFbyes.Text == "")
                {
                    lblErorMessage.InnerText = "Enter Share Quantiy";
                }
                else if (txtTotalPrice.Text == "0.00" || txtTotalPrice.Text == "")
                {
                    lblErorMessage.InnerText = "Enter Share Quantiy";
                }

                else
                {

                    GameMenuDetails gm = new GameMenuDetails();

                    bool status = gm.BuyShare(txtNumberOFbyes.Text.ToString(), Convert.ToDouble(txtTotalPrice.Text.ToString()), Session["UserID"].ToString(), ddlSector1.SelectedValue.ToString(), ddlCompany1.SelectedValue.ToString());

                    MarketDetails();
                    Clear();
                    getBankBalance();

                }
            }
        }

        protected void btnSell_Click(object sender, EventArgs e)
        {


            if (txtNumberOFbyes.Text == "0" || txtNumberOFbyes.Text == "")
            {
                lblErorMessage.InnerText = "Enter Share Quantiy";
            }
            else if (txtTotalPrice.Text == "0" || txtTotalPrice.Text == "")
            {
                lblErorMessage.InnerText = "Enter Share Quantiy";
            }

            else
            {

                GameMenuDetails gm = new GameMenuDetails();
                DataTable dt = new DataTable();
                dt = gm.CheckShare(Session["UserID"].ToString(), ddlSector1.SelectedValue.ToString(), ddlCompany1.SelectedValue.ToString());
                if (Convert.ToInt16(dt.Rows[0][0].ToString()) >= Convert.ToInt16(txtNumberOFbyes.Text.ToString()))
                {
                    bool status = gm.SellShare(txtNumberOFbyes.Text.ToString(), Convert.ToDouble(txtTotalPrice.Text.ToString()), Session["UserID"].ToString(), ddlSector1.SelectedValue.ToString(), ddlCompany1.SelectedValue.ToString());
                }
                else
                {
                    lblErorMessage.InnerText = "Invalid Shares";
                }
                MarketDetails();
                Clear();
                getBankBalance();

            }

        }


        protected void btnSignOut_Click(object sender, EventArgs e)
        {
            GameMenuDetails gm = new GameMenuDetails();
            bool Ststus1 = gm.SignOut(Session["UserID"].ToString());

            if (Ststus1 == true)
            {
                Session.Clear();
                Response.Redirect("Login.aspx");

            }
        }
        public void Clear()
        {
            txtTotalPrice.Text = "00.00";
            txtNumberOFbyes.Text = "0";

        }


        public void CheckCondition()
        {
            if (Chances == 5)
            {
                Response.Redirect("ScoreBoard.aspx");
            }

        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                GameMenuDetails aaa = new GameMenuDetails();
                DataTable dt1 = new DataTable();
                dt1 = aaa.GetPlayRound(Session["UserID"].ToString());

                //if (dt1.Rows[0][0].ToString() == "1")
                //{
                //    bool IsSuccess = aaa.ExecutePCPlayer();

                //}


                NavCountDown.InnerText = "Time Left (Round)- " + (Convert.ToInt32(Session["CountID"]) - 1).ToString() + "s";
                Session["CountID"] = Convert.ToInt32(Session["CountID"]) - 1;
                if (Convert.ToInt32(Session["CountID"]) == 0)
                {

                    Session["CountID"] = 10;
                    GameMenuDetails gm = new GameMenuDetails();
                    bool Ststus1 = gm.UpdatePLayerRound(Session["UserID"].ToString());
                    PlayRoundCheck();

                    if (NavUserChance.InnerText == "Round -11")
                    {
                        //bool Ststus3 = gm.TempCurrentPlayers(Session["UserID"].ToString());
                        Response.Redirect("ScoreBoard.aspx");
                    }
                }
            }
            catch (Exception ex)
            { 
            
            
            }

        }

        protected void Timer2_Tick(object sender, EventArgs e)
        {
            GameMenuDetails gm = new GameMenuDetails();

            //if (Session["Execute"].ToString() == "1")
            //{

                bool Ststus2 = gm.BasicValueChange();
                MarketDetails();

                DataTable dt = new DataTable();
                dt = gm.CheckEventOccurCompany(NavUserChance.InnerText);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        bool Istrue = gm.ExecuteEventOccurCompany(dt.Rows[i][2].ToString(), dt.Rows[i][1].ToString());
                        MarketDetails();
                    }
                }


                DataTable dt1 = new DataTable();
                dt1 = gm.CheckEventOccurSector(NavUserChance.InnerText);
                if (dt1.Rows.Count > 0)
                {
                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        bool Istrue = gm.ExecuteEventOccurSector(dt1.Rows[i][2].ToString(), dt1.Rows[i][1].ToString());
                        MarketDetails();
                    }
                }

               

            //}

            bool IsSuccess = gm.ExecutePCPlayer();
            MarketDetails();
            Series series = Chart2.Series["Series2"];
            DataTable dtChart = new DataTable();
            dtChart = gm.GetChartDetails();


            for (int i = 0; i < dtChart.Rows.Count; i++)
            {
                series.Points.AddXY(dtChart.Rows[i][1].ToString(), dtChart.Rows[i][2].ToString());

            }

        }
    }
}