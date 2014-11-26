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

        SqlCommand cmdInsert = new SqlCommand("Insert into Emp(ID, FName, LName, Contact, Email, Ocheck, Ext, Facilitator) VALUES ('" + ((TextBox)GridView1.FooterRow.FindControl("txtID")).Text + "','" + ((TextBox)GridView1.FooterRow.FindControl("txtFName")).Text + "','" + ((TextBox)GridView1.FooterRow.FindControl("txtLName")).Text + "','" + ((TextBox)GridView1.FooterRow.FindControl("txtContact")).Text + "','" + ((TextBox)GridView1.FooterRow.FindControl("txtEmail")).Text + "','" + ((TextBox)GridView1.FooterRow.FindControl("txtOCheck")).Text + "','" + ((TextBox)GridView1.FooterRow.FindControl("txtExt")).Text + "','" + ((TextBox)GridView1.FooterRow.FindControl("txtFacilitator")).Text + "')", conn);
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
    protected void btnFacilitator_Click(object sender, EventArgs e)
    {
        string name = DropDownListNames.Text;
        string fname = "", lname = "";

        for (int i = 0; i < name.Length; i++)
        {
            if (name.Substring(i, 1) == " ")
            {
                lname = name.Substring(i + 1, name.Length - fname.Length - 1);
                break;
            }
            fname = fname + name.Substring(i, 1);
        }

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        conn.Open();

        //get id from the first and last name combo box
        string checkID = "Select ID from Emp where FName = '" + fname + "' and LName = '" + lname + "'";
        SqlCommand cmd = new SqlCommand(checkID, conn);
        int idReturned = Convert.ToInt32(cmd.ExecuteScalar().ToString());

        Response.Redirect("FacilitatorPasswordSet.aspx?id=" + idReturned);
    }
    protected void btnRemoveFacilitator_Click(object sender, EventArgs e)
    {
        string name = DropDownListRemoveFacilitator.Text;
        string fname = "", lname = "";

        for (int i = 0; i < name.Length; i++)
        {
            if (name.Substring(i, 1) == " ")
            {
                lname = name.Substring(i + 1, name.Length - fname.Length - 1);
                break;
            }
            fname = fname + name.Substring(i, 1);
        }

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        conn.Open();

        //get id from the first and last name combo box
        string checkID = "Select ID from Emp where FName = '" + fname + "' and LName = '" + lname + "'";
        SqlCommand cmd = new SqlCommand(checkID, conn);
        int id = Convert.ToInt32(cmd.ExecuteScalar().ToString());

        SqlCommand cmdRemove = new SqlCommand("Delete from Facilitator where ID = '" + id +"'",conn);
        cmdRemove.ExecuteNonQuery();

        SqlCommand cmdChangeOCheck = new SqlCommand("Update Emp set Facilitator = 'N' where ID ='" + id + "'",conn);
        cmdChangeOCheck.ExecuteNonQuery();

        GridView1.DataBind();
        DropDownListRemoveFacilitator.DataBind();
        conn.Close();
    }
}