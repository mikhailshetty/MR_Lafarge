using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Tracker : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnSignIn_Click(object sender, EventArgs e)
    {
        string name = DropDownListNames.Text;
        string fname="",lname="";

        for(int i=0; i<name.Length; i++)
        {
            if(name.Substring(i,1) == " ")
            {
                lname = name.Substring(i + 1, name.Length - fname.Length - 1);
                break;
            }
            fname = fname + name.Substring(i, 1);
        }
        
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        conn.Open();
        string checkID = "Select ID from Emp where FName = '" + fname + "' and LName = '" + lname + "'";
        SqlCommand cmd = new SqlCommand(checkID, conn);
        int id = Convert.ToInt32(cmd.ExecuteScalar().ToString());
        SqlCommand cmdInsert = new SqlCommand("Insert into TimeLog(ID,Date,SignIN) VALUES ('" + Convert.ToString(id) + "','" + DateTime.Now + "','" + DateTime.Now + "')", conn);
        int numberofrows = cmdInsert.ExecuteNonQuery();
        conn.Close();
        GridView1.DataBind();
    }
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Response.Redirect("EditPage.aspx");
    }
    protected void btnOrientation_Click(object sender, EventArgs e)
    {
        Response.Redirect("Orientation.aspx");
    }
}