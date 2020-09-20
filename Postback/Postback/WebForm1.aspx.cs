using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Postback
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(this.IsPostBack + "<br/>");
            if (this.IsPostBack)
                Response.Write("Autopostback: " + TextBox1.Text + "<br/>");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (this.IsPostBack)
                Response.Write("After submitting: text :" + TextBox1.Text + "<br/>");
        }
    }
}