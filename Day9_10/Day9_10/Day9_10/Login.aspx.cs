using System;
using System.Text;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;

namespace Day9_10
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelInvalid.Visible = false; //visibility false
        }
        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            MySqlConnection con;
            MySqlCommand cmd;
            object usrpsw;
            con = new MySqlConnection();
            StringBuilder strBuildObject;
            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                if (con != null && con.State == ConnectionState.Closed)
                {
                    con.Open();//open the connection                        
                }
                //Existance in employees Table
                strBuildObject = new StringBuilder("select FirstName, LastName ");
                strBuildObject.Append(" from employees");
                strBuildObject.Append(" where FirstName='" + usrname.Text + "' COLLATE Latin1_General_CS_AS AND LastName='" + pswd.Text + "' COLLATE Latin1_General_CS_AS ;");
                cmd = new MySqlCommand(strBuildObject.ToString(), con);
                usrpsw = cmd.ExecuteScalar();
                if (usrpsw != null)
                {
                    Session["UserName"] = usrname.Text; //Username stored in Session
                    Response.Redirect("Secure.aspx");
                }
                else
                {
                    LabelInvalid.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}