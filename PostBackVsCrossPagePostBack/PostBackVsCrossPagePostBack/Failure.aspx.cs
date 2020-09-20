using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PostBackVsCrossPagePostBack
{
    public partial class Failure : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string wrongUser = Request.QueryString["Name"];
            Response.Write("Hello " + wrongUser + " your user name or password is incorrect.");
        }
    }
}