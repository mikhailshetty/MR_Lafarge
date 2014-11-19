using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class EditOptions : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        conn.Open();

        SqlCommand cmdInsert = new SqlCommand("Insert into Emp(ID, FName, LName, Contact, Email, Ocheck, Ext, Facilitator) VALUES ('" + ((TextBox)GridView1.FooterRow.FindControl("txtID")).Text + "','" + ((TextBox)GridView1.FooterRow.FindControl("txtFName")).Text + "','" + ((TextBox)GridView1.FooterRow.FindControl("txtLName")).Text + "','" + ((TextBox)GridView1.FooterRow.FindControl("txtContact")).Text + "','" + ((TextBox)GridView1.FooterRow.FindControl("txtEmail")).Text + "','" + ((TextBox)GridView1.FooterRow.FindControl("txtOCheck")).Text + "','" + ((TextBox)GridView1.FooterRow.FindControl("txtExternal")).Text + "','" + ((TextBox)GridView1.FooterRow.FindControl("txtFacilitator")).Text + "')", conn);
         int numberofrows = cmdInsert.ExecuteNonQuery();
        conn.Close();
        GridView1.DataBind();
        
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void txtID_TextChanged(object sender, EventArgs e)
    {

    }
}