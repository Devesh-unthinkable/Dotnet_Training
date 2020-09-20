using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PostBackVsCrossPagePostBack
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                txtName.Focus();
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "admin" && txtPwd.Text == "admin")
            {
                Server.Transfer("Success.aspx");
            }
            else
            {
                Response.Redirect("Failure.aspx?Name=" + txtName.Text + "&Pwd=" + txtPwd.Text);
            }

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {

        }
    }
}