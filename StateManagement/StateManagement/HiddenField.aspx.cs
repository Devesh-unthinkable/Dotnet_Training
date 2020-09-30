using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class HiddenField : System.Web.UI.Page
    {
        int count;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            count = int.Parse(hfCount.Value);
            count += 1;
            Response.Write("Hit Count = " + count);
            hfCount.Value = count.ToString();
        }
    }
}