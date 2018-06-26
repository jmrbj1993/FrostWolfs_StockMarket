using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace STMSM
{
    public partial class CurrentPlayersGame : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Players();
        }


        public void Players()
        {
            GameMenuDetails gm = new GameMenuDetails();
            DataTable dt = new DataTable();
            dt = gm.CurrentPlayers();
            int RowCount = dt.Rows.Count;
            RptHistory.DataSource = dt;
            RptHistory.DataBind();
        
        
        }
        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Players();
        }
    }
}