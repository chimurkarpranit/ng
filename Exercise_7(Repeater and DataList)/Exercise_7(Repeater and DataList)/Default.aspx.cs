///Day 8 : Exercise_7 Repeater and DataList Control
///Created By: Pranit Chimurkar
///Date: 2019/08/02
using System;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;

namespace Exercise_7_Repeater_and_DataList_
{
    public partial class _Default : System.Web.UI.Page
    {
        Int32 CurrentPage;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["PageCount"] = 0;                    // ViewState for PageCount
                CurrentPage = (int)ViewState["PageCount"];
            }
        }
        protected void BtnRecords_Click(object sender, EventArgs e)
        {
            SortData();  // SortData Function for sorting data as the value of dropdown list
        }
        public void SortData()  // SortData Function defined
        {
            string Value = ddlSort.SelectedValue;
            string conStr = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString; //ConfigurationManager
            using (MySqlConnection con = new MySqlConnection(conStr))
            {
                //if(con.State == ConnectionState.Open)
                //{
                //    Response.Write("Yes");
                //}
                //else
                //{
                //    Response.Write("No");
                //}
                using (MySqlCommand cmd = new MySqlCommand("select * from employees ORDER BY " + Value + "", con)) //SQL Query of employee table
                {
                    using (MySqlDataAdapter sqlAdapt = new MySqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sqlAdapt.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sqlAdapt.Fill(dt);
                            Repeater1.DataSource = dt;
                            DataList1.DataSource = dt;
                            Repeater1.DataBind();
                            DataList1.DataBind();
                            PagingFunction(dt);  //PagingFunction function for Paging of Repeater and DataList
                        }
                    }
                }
            }
        }
        private void PagingFunction(DataTable dt) //PagingFunction Function
        {
            PagedDataSource PageD = new PagedDataSource();
            PageD.DataSource = dt.DefaultView;
            PageD.PageSize = 5;
            PageD.AllowPaging = true;
            PageD.CurrentPageIndex = CurrentPage;

            BtnOne.Enabled = !PageD.IsFirstPage;
            BtnTwo.Enabled = !PageD.IsLastPage;

            ViewState["TotalCount"] = PageD.PageCount;
            DataList1.DataSource = PageD;
            DataList1.DataBind();
            Repeater1.DataSource = PageD;
            Repeater1.DataBind();
            ViewState["PageSource"] = dt;
        }
        protected void Btn1_Click(object sender, EventArgs e)
        {
            CurrentPage = 0;
            Repeater1.DataSource = (DataTable)ViewState["PageSource"];
            Repeater1.DataBind();
            DataList1.DataSource = (DataTable)ViewState["PageSource"];
            DataList1.DataBind();
        }
        protected void Btn2_Click(object sender, EventArgs e)
        {
            CurrentPage = (int)ViewState["TotalCount"] - 1;
            PagingFunction((DataTable)ViewState["PageSource"]);
        }
    }
}