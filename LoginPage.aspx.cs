﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class ContentPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void BtnLogin_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        conn.Open();
        string checkID = "Select count(*) from SiteManager where ID = '" + txtID.Text + "'";
        SqlCommand cmd = new SqlCommand(checkID, conn);
        int temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());
        conn.Close();
        if (temp == 1)
        {
            conn.Open();
            string checkPassword = "Select Pasword from SiteManager where ID = '" + txtID.Text + "'";
            SqlCommand passCmd = new SqlCommand(checkPassword, conn);
            string password = passCmd.ExecuteScalar().ToString().Replace(" ", "");
            if (password == txtPassword.Text)
            {
                Session["New"] = txtID.Text;
                lblResult.Text = "Logged In";
                Response.Redirect("Tracker.aspx");
            }
            else
            {
                lblResult.Text = "Invalid UserName or Password";
            }
        }
        else
        {
            lblResult.Text = "Invalid ID or Password";
        }
    }
}