using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
public partial class FacilitatorApproval : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    private bool checkIfBothEntered()
    {
        if (txtID.Text == "" || txtPassword.Text == "")
        { return false; }
        else return true;
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (checkIfBothEntered())
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            conn.Open();
            int enteredID, temp = 0;
            if (int.TryParse(txtID.Text, out enteredID))
            {
                string checkID = "Select count(*) from Facilitator where ID = '" + txtID.Text + "'";

                SqlCommand cmd = new SqlCommand(checkID, conn);
                temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            }
            else
            {
                AlertWindow.Visible = true;
                AlertWindow.Text = "Please enter a valid ID";
                AlertWindow.CssClass = "alert alert-warning";
            }
            if (temp == 1)
            {
                string checkPassword = "Select Password from Facilitator where ID = '" + txtID.Text + "'";
                SqlCommand passCmd = new SqlCommand(checkPassword, conn);
                string password = passCmd.ExecuteScalar().ToString().Replace(" ", "");
                if (password == txtPassword.Text)
                {
                    Session["New"] = txtID.Text;
                    //Response.Write( "Logged In");
                    AlertWindow.Visible = true;
                    AlertWindow.Text = "Authentication successful";
                    AlertWindow.CssClass = "alert alert-success";
                    Response.Redirect("Orientation.aspx");
                }
                else
                {
                    // lblResult.Text = "Invalid UserName or Password";
                    AlertWindow.Visible = true;
                    AlertWindow.Text = "Invalid credentials";
                    AlertWindow.CssClass = "alert alert-danger";
                }
            }
            else
            {
                //  lblResult.Text = "Invalid ID or Password";
                AlertWindow.Visible = true;
                AlertWindow.Text = "Invalid credentials";
                AlertWindow.CssClass = "alert alert-danger";
            }
            conn.Close();
        }
        else
        {
            AlertWindow.Visible = true;
            AlertWindow.Text = "Please enter both the ID and the Password.";
            AlertWindow.CssClass = "alert alert-warning";
        }
    }
}