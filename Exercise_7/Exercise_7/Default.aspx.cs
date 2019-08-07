///Day 8 : Exercise_7 Repeater and DataList Control
///Created By: Pranit Chimurkar
///Date: 2019/08/02
using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercise_7
{
    public partial class _Default : Page
    {
        int CurrentPage;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["PageCount"] = 0;
                CurrentPage = (int)ViewState["PageCount"];

            }
        }
        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }
        protected void ButtonDisplay(object sender, EventArgs e)
        {
            SortData();
        }

        public void SortData()
        {
            string Value = DropDownList1.SelectedValue;
            string conStr = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            MySqlConnection con = new MySqlConnection(conStr);
            MySqlCommand cmd = new MySqlCommand("select * from employees ORDER BY " + Value + "", con);
            MySqlDataAdapter sqlAdapt = new MySqlDataAdapter();

            cmd.Connection = con;
            sqlAdapt.SelectCommand = cmd;
            DataTable dt = new DataTable();

            sqlAdapt.Fill(dt);
            Repeater1.DataSource = dt;
            DataList1.DataSource = dt;
            Repeater1.DataBind();
            DataList1.DataBind();
            DataListPaging(dt);
        }
        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void DataListPaging(DataTable dt)
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
            DataListPaging((DataTable)ViewState["PageSource"]);
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}