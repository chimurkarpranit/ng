//Created By :Aditya Mhetre
//Date : 2019/08/02
//Class : Default Page
//Description :9.1
using System;
using System.IO;

namespace Day_9_10
{
    public partial class Exercise9Text : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = File.OpenText(Server.MapPath("Aditya1.txt"));
                string strContents = sr.ReadToEnd();
                //To handle Carriage returns
                Response.Write(strContents.Replace("\n", "<br>"));


            }

            catch (Exception ex)
            {

                Page_Error(sender, e);
            }
        }

        public void Page_Error(object sender, EventArgs e)
        {
            Exception objError = Server.GetLastError().GetBaseException();
            string strError = "Error Has Been Caught in Page_Error event";
            Response.Write(strError.ToString());
            Server.ClearError();
        }
    }
}
