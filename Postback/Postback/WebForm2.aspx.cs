using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Postback
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Load event fired: <br/>");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Response.Write("Cached event fired: <br/>");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Post back event fired: <br/>");
        }
    }
}