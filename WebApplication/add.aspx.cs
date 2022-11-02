using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication
{
    public partial class add : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=Moback;Initial Catalog=webform;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void insert_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spinserttostudent", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@studentname", SqlDbType.VarChar).Value = studentname.Text.ToString();
                cmd.Parameters.Add("@branch", SqlDbType.VarChar).Value = branch.Text.ToString();
                cmd.Parameters.Add("@division", SqlDbType.VarChar).Value = division.Text.ToString();
                cmd.ExecuteNonQuery();
                message.Text = "data uploaded successfully";
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