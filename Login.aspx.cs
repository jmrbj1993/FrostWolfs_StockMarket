using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace STMSM
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_ServerClick(object sender, EventArgs e)
        {
            if (inputText.Value == "")
            {
            lblErorMessage.InnerHtml="Enter UserName";
            }
            else if (inputPassword.Value == "")
            {
                lblErorMessage.InnerHtml = "Enter Password";
            }
            else
            {

                LDetails oi = new LDetails();
                DataTable dt = new DataTable();
                dt = oi.CheckLogin(inputText.Value, inputPassword.Value);
                int RowCount = dt.Rows.Count;

                if (RowCount == 0)
                {
                    lblErorMessage.InnerHtml = "Invalid UserName and Password";
                }
                else
                {
                    string userid = dt.Rows[0][0].ToString();
                    string name = dt.Rows[0][1].ToString();
                    Session["UserID"] = userid;
                    Session["UserName"] = name;

                    bool Istrue = oi.InsertValues(inputText.Value, Session["UserID"].ToString());

                    if (Istrue == true)
                    {


                        bool IstrueCheck = oi.InserUserMarkettValues(userid);
                        bool IstrueCheckBalace = oi.InsertBankBalance(userid);
                        bool IstrueCheckPlayerRound = oi.InsertPlayerRound(userid);
                        bool IsCLearHistory = oi.ClearHistory(userid);
                        bool IsCLearTempCurrentPlayers = oi.ClearTempCurrentPlayers(userid);
                        DataTable dt1 = new DataTable();
                        dt1 = oi.ExecuteOrder(Session["UserID"].ToString());
                        string exval = dt1.Rows[0][0].ToString();

                        if (rdM.Checked == true)
                        {
                            Session["Execute"] = exval;

                            if (Session["Execute"].ToString() == "1")
                            {

                                bool IstrueEventOccurCompany = oi.EventOccurCompanySetup();
                                bool IstrueEventOccurEvent = oi.EventOccurSectorSetup();
                               // bool ISc = oi.ClearCP(Session["UserID"].ToString());
        
                            }

                            Response.Redirect("WaitingForPlayers.aspx");
                        }
                        else
                        {
                            Session["Execute"] = exval;

                            //if (Session["Execute"].ToString() == "1")
                            //{
                            //bool ISc = oi.ClearCP(Session["UserID"].ToString());
                            bool IstrueEventOccurCompany = oi.EventOccurCompanySetup();
                            bool IstrueEventOccurEvent = oi.EventOccurSectorSetup();
                            
                            //}

                            //Response.Redirect("WaitingForPlayers.aspx");
                            bool isval = oi.DeletePcPlayerValues();
                            Response.Redirect("GamePC.aspx");
                        }

                    }




                }
            }
        }

        protected void rdM_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        protected void rdS_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        protected void BtnSignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUp.aspx");
        }
    }
}