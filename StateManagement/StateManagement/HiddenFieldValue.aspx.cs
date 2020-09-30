using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class HiddenFieldValue : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string message = Request.Form["hfCount"];
            Response.Write("Mouse clicked " + message + " times");
        }
    }
}