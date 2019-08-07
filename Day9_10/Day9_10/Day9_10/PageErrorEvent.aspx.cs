using System;
using System.IO;

namespace Day9_10
{
    public partial class PageErrorEvent : System.Web.UI.Page
    {
        string FileName = string.Empty;
        StreamReader str;
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Form.DefaultButton = ErrorButton1.UniqueID;
            Page.Form.DefaultButton = ErrorButton2.UniqueID;
        }
        protected void ErrorButtonClick1(object sender, EventArgs e)
        {
                FileName = Server.MapPath("File.txt");
                str = File.OpenText(FileName);
                FileContents.Text = "This is the content of file<br/>" + str.ReadToEnd();
                str.Close();           
        }
        protected void ErrorButtonClick2(object sender, EventArgs e)
        {
            Exception obErr = new Exception();
            obErr = Server.GetLastError().GetBaseException();


            string err = "Error has caught in page error event" +
                              "Error In: " + Request.Url.ToString() +
                              "Error Message: " + obErr.Message.ToString() +
                              "Stack Trace: " + obErr.StackTrace.ToString();
            Response.Write(err.ToString());
        }
    }
}