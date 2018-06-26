using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace STMSM
{
    public partial class HistoryOfUsers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HistoryOFData();
        }

        public void HistoryOFData()
        {
            HistoryD gm = new HistoryD();
            DataTable dt = new DataTable();
            dt = gm.MarketDetails(Session["UserID"].ToString());
            RptHistory.DataSource = dt.DefaultView;
            RptHistory.DataBind();
        
        }
    }
}