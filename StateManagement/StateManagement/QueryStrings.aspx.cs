using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class QueryStrings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtName.Focus();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "admin" && txtPwd.Text == "admin")
            {
                Response.Redirect("~/QueryStringOutput.aspx?Name=" + txtName.Text);
            }
            else
            {
                Response.Write("Invalid User");
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = txtPwd.Text = "";
            txtName.Focus();
        }
    }
}