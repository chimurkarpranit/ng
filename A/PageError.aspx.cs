using System;

namespace Day_9_10
{
    public partial class PageError : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Application Error Occured");
        }

    }
}