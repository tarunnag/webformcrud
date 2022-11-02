using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web.Services.Description;

namespace WebApplication
{
    public partial class edit : System.Web.UI.Page
    {
        SqlConnection con1 = new SqlConnection(@"Data Source=Moback;Initial Catalog=webform;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                passvalue2.Text = Request.QueryString["id"];
            }
            if (!IsPostBack)
            {
                showdata();
            }
        }
        protected void showdata()
        {
            
            try
            {
                con1.Open();
                SqlCommand cmd = new SqlCommand("select * from student where id =" + passvalue2.Text, con1);
                SqlDataReader rdr = null;
                rdr= cmd.ExecuteReader();
                if (rdr.Read())
                {
                    studentname.Text = rdr["studentname"].ToString();
                    branch.Text = rdr["branch"].ToString();
                    division.Text = rdr["division"].ToString();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                con1.Close();
            }
            }
        protected void update_Click(object sender, EventArgs e)
        {
            try
            {
                con1.Open();
                SqlCommand cmd = new SqlCommand("updatedata", con1);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id",SqlDbType.Int).Value=(int.Parse(passvalue2.Text));
                cmd.Parameters.Add("@studentname", SqlDbType.VarChar).Value = studentname.Text.ToString();
                cmd.Parameters.Add("@branch", SqlDbType.VarChar).Value = branch.Text.ToString();
                cmd.Parameters.Add("@division", SqlDbType.VarChar).Value = division.Text.ToString();
                cmd.ExecuteNonQuery();
                message2.Text = "data uploaded successfully";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
    }
} 