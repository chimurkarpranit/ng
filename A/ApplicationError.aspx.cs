using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day_9_10
{
    public partial class ApplicationError : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Server.Transfer("Welcome.aspx");
            }
            catch
            {
                Response.Redirect("PageError.aspx");
            }
        }
    }
}

    
