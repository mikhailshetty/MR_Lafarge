using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
public partial class ContentPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        conn.Open();
        SqlCommand cmd = new SqlCommand("Select OrientationDate, ID from Emp", conn);    
        
        int i=0, count = 0;

        using (var reader = cmd.ExecuteReader())
        {
            while (reader.Read())
            {
                if((DateTime.Now - (DateTime)reader["OrientationDate"]).TotalDays >365)
                {
                    count = count +1;
                }
            }
        }
        int[] ids;
        ids = new int[count];
        using (var reader = cmd.ExecuteReader())
        {
            while (reader.Read())
            {
                if((DateTime.Now - (DateTime)reader["OrientationDate"]).TotalDays >365)
                {
                    ids[i] = (int)reader["ID"];
                    i = i+1;
                }
            }
        }

        for (int x = 0; x < count; x++)
        {
            //MessageBox.Show(ids[x] + " ");
            SqlCommand cmdupdate = new SqlCommand("Update Emp set Ocheck = 'N' where ID ='" + ids[x] + "'", conn);
            cmdupdate.ExecuteNonQuery();
        }

        //SqlCommand cmdSignOut = new SqlCommand("Select Date, ID from TimeLog where SignOUT = NULL", conn);
        //int temp = 0, countS = 0;

        //using (var reader = cmdSignOut.ExecuteReader())
        //{
        //    while (reader.Read())
        //    {
        //        if ((DateTime.Now - (DateTime)reader["Date"]).TotalDays > 0)
        //        {
        //            countS = countS + 1;
        //        }
        //    }
        //}
        //int[] idSignOut;
        //idSignOut = new int[countS];
        //using (var reader = cmdSignOut.ExecuteReader())
        //{
        //    while (reader.Read())
        //    {
        //        if ((DateTime.Now - (DateTime)reader["Date"]).TotalDays >= 1)
        //        {
        //            idSignOut[i] = (int)reader["ID"];
        //            temp = temp + 1;
        //        }
        //    }
        //}

        //for (int x = 0; x < countS; x++)
        //{
        //    MessageBox.Show(idSignOut[x] + " ");
        //    //SqlCommand cmdupdate = new SqlCommand("Update Emp set Ocheck = 'N' where ID ='" + ids[x] + "'", conn);
        //    //cmdupdate.ExecuteNonQuery();
        //}
        conn.Close();
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
                    AlertWindow.Visible = true;
                    AlertWindow.Text = "Successfully logged in.";
                    AlertWindow.CssClass = "alert alert-success";
                    Response.Redirect("Tracker.aspx");
                }
                else
                {
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
        }
        else
        {
            AlertWindow.Visible = true;
            AlertWindow.Text = "Please enter both the ID and the Password.";
            AlertWindow.CssClass = "alert alert-warning";
        }
    }
    protected void txtID_TextChanged(object sender, EventArgs e)
    {
        AlertWindow.Visible = false;
    }
}