using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace STMSM
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnConfirm_Click(object sender, EventArgs e)
        { 
            try{
            SupDetails sp=new SupDetails();
             bool val=  sp.SignUpUserDetails(txtUserName.Text.ToString(),txtPassword.Text.ToString());
            if (val==true)
            {
            lblMessage.InnerText="Successfully";
            }
            else
            {
            lblMessage.InnerText="Failed";
            }
            }
            catch(Exception ex)
            {
            
            }

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
        
        
        }
    }
