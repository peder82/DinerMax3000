using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DinerMax3000.Web
{
    public partial class DinerMax3000MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["TotalPageCount"] == null)
            {
                Session["TotalPageCount"] = 0;
            }
            Session["TotalPageCount"] = (int)Session["TotalPageCount"] + 1;
        }
    }
}