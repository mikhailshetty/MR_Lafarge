using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

public partial class FacilitatorPasswordSet : System.Web.UI.Page
{
    public int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request.QueryString["id"]))
        {
            id = Convert.ToInt32(Request.QueryString["id"]);
            lblFacilitator.Text = Request.QueryString["id"];
        }
        else
        {
            lblFacilitator.Text = "NO DATA PROVIDED OR COULD NOT BE READ";
        }
    }
    protected void btnSet_Click(object sender, EventArgs e)
    {
        if (txtPassword.Text != txtReEnter.Text)
        {
            MessageBox.Show("Passwords do not match.");            
        }
        else
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            conn.Open();

            //get id from the first and last name combo box
            SqlCommand cmd = new SqlCommand("Insert into Facilitator(ID, Password) VALUES ('" + id + "' , '"+ txtPassword.Text+ "')" , conn);
            cmd.ExecuteNonQuery();

            SqlCommand cmdUpdate = new SqlCommand("Update Emp set Facilitator = 'Y' where ID = '" + id + "'",conn);
            cmdUpdate.ExecuteNonQuery();

            MessageBox.Show("New Facilitator created");

            Response.Redirect("EditOptions.aspx");
            conn.Close();
        }
    }
}