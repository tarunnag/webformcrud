using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace WebApplication
{
    public partial class WebForm : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                databind();
            }
        }
        protected void databind()
        {
            SqlConnection con = new SqlConnection(@"Data Source=Moback;Initial Catalog=webform;Integrated Security=True");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from student", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds= new DataSet();
                adapter.Fill(ds);
                DropDownList1.DataSource=ds;
                DropDownList1.DataTextField = "studentname";
                DropDownList1.DataValueField = "id";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, new ListItem("select", "0"));
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        protected void insert_Click(object sender, EventArgs e)
        {

        }

        protected void add_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/add.aspx");
        }

        protected void edit_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/edit.aspx?id=" +passvalue.Text);
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            passvalue.Text = DropDownList1.SelectedItem.Value;
        }
    }
}