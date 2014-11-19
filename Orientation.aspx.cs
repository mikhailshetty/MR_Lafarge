using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Orientation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
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
        string checkID = "Select ID from Emp where FName = '" + fname + "' and LName = '" + lname + "'";
        SqlCommand cmd = new SqlCommand(checkID, conn);
        int id = Convert.ToInt32(cmd.ExecuteScalar().ToString());
        SqlCommand cmdUpdate = new SqlCommand("Update Emp set Ocheck = 'Y' where ID = '" + id + "'", conn);
        cmdUpdate.ExecuteNonQuery();
        conn.Close();
    }
}