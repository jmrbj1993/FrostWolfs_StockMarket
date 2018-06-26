using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace STMSM
{
    public partial class WaitingForPlayers : System.Web.UI.Page
    {
        public int Progress = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
           
                
          Players();
             
        }

        public void Players()
        {
            try
            {
                GameMenuDetails gm = new GameMenuDetails();
                DataTable dt = new DataTable();
                dt = gm.CurrentPlayers();
                int RowCount = dt.Rows.Count;
                Repeater1.DataSource = dt;
                Repeater1.DataBind();

                if (RowCount == 1)
                {
                    //Response.Redirect("Game.aspx");


                    lblMessage.InnerText = "Need Two  Player Start The Game";

                }
                else if (RowCount == 2)
                {
                    //Response.Redirect("Game.aspx");


                    lblMessage.InnerText = "Need One Player Start The Game";

                }
                else if (RowCount == 3)
                {
                    if (Session["Execute"].ToString() == "1")
                    {
                        Response.Redirect("Game.aspx");
                    }
                    else
                    {
                        System.Threading.Thread.Sleep(2000);
                        Response.Redirect("Game.aspx");
                    }

                }

            }
            catch (Exception ex)
            { 
            
            
            }
        
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Players();
        }

        protected void btnStart_Click(object sender, EventArgs e)
        {
            Response.Redirect("Game.aspx");
        }
    }
}