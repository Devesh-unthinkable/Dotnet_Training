using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PostBackVsCrossPagePostBack
{
    public partial class Success : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page pp = PreviousPage;
            Control ctrl = pp.FindControl("txtName");
            TextBox tb = (TextBox)ctrl;
            string Name = tb.Text;
            Response.Write("Hello " + Name + " Welcome to our website.");
        }
    }
}