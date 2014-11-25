using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class EditPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        AlertWindow.Visible = false; 
    }
    private bool checkIfBothEntered()
    {
        if (txtID.Text == "" || txtPassword.Text == "")
        { return false; }
        else return true;
    }
    protected void BtnSubmit_Click(object sender, EventArgs e)
    {
        if (checkIfBothEntered())
        {
            int temp = 0;
            int enteredID;
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            conn.Open();
            if (int.TryParse(txtID.Text, out enteredID))
            {
                string checkID = "Select count(*) from SiteManager where ID = '" + txtID.Text + "'";
                SqlCommand cmd = new SqlCommand(checkID, conn);
                temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                conn.Close();
            }
            else
            {
                AlertWindow.Visible = true;
                AlertWindow.Text = "Please enter a valid ID";
                AlertWindow.CssClass = "alert alert-warning";
            }
            if (temp == 1)
            {
                conn.Open();
                string checkPassword = "Select Pasword from SiteManager where ID = '" + txtID.Text + "'";
                SqlCommand passCmd = new SqlCommand(checkPassword, conn);
                string password = passCmd.ExecuteScalar().ToString().Replace(" ", "");
                if (password == txtPassword.Text)
                {
                    Session["New"] = txtID.Text;
                    //  lblResult.Text = "Verified Manager";
                    AlertWindow.Visible = true;
                    AlertWindow.Text = "Authorized Login";
                    AlertWindow.CssClass = "alert alert-success";
                    Response.Redirect("EditOptions.aspx");
                }
                else
                {
                    AlertWindow.Visible = true;
                    AlertWindow.Text = "Invalid credentials";
                    AlertWindow.CssClass = "alert alert-danger";
                    // lblResult.Text = "Verification Failed";
                }
            }
            else
            {
                AlertWindow.Visible = true;
                AlertWindow.Text = "Invalid credentials";
                AlertWindow.CssClass = "alert alert-danger";
                // lblResult.Text = "Verification Failed";
            }
        }
        else
        {
            AlertWindow.Visible = true;
            AlertWindow.Text = "Please enter both the ID and the Password.";
            AlertWindow.CssClass = "alert alert-warning";
        }
    }
}