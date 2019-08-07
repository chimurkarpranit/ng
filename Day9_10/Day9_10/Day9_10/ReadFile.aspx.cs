using System;
using System.IO;
using System.Web.UI;

namespace Day9_10
{
    public partial class ReadFile : Page
    {
        string FileName = string.Empty; //variable for filename
        StreamReader str;
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Form.DefaultButton = ErrorButton.UniqueID;
        }
        private void Readf()//Function for reading file data using StramReader
        {
            try
            {
                FileName = Server.MapPath("File.txt");
                str = File.OpenText(FileName);
                filedata.Text = "This is the content of file<br/>" + str.ReadToEnd();
                str.Close();
            }
            catch (FileNotFoundException f)
            {
                filedata.Text = f.Message.ToString();//Exception if file not present
            }
            finally
            {
                str = null; //StreamReader cleared
            }
        }
        protected void ErrorButtonClick(object sender, EventArgs e)
        {
            Readf();//Function calling on error button clicking
        }
    }
}