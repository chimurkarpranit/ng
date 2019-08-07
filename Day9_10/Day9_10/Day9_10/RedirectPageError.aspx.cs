using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day9_10
{
    public partial class RedirectPageError : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Form.DefaultButton = ErrorButton3.UniqueID;
        }

        protected void ErrorButtonClick3(object sender, EventArgs e)
        {

        }
    }
}