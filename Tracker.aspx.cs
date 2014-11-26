using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using AjaxControlToolkit;
using System.Text;
using System.Net.Mail;

public partial class Tracker : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            GridView1.DataBind();
            AlertWindow.Visible = false;

        }
    }

   // [System.Web.Services.WebMethodAttribute(),
   //System.Web.Script.Services.ScriptMethodAttribute()]
   // public static string GetDynamicContent(string contextKey)
   // {
   //     SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
   //     conn.Open();
   //     //string constr = "Server=TestServer;Database=SampleDatabase;uid=test;pwd=test;";
   //     //string query = "SELECT UnitPrice, UnitsInStock, Description FROM Products WHERE ProductID = " + contextKey;
   //     SqlCommand cmd = new SqlCommand("Select Contact, Email, Ocheck from Emp WHERE ID='" + contextKey + "'", conn);
   //     SqlDataAdapter da = new SqlDataAdapter(cmd);
   //     DataTable table = new DataTable();
   //     MessageBox.Show("Creating table");
   //     da.Fill(table);

   //     StringBuilder b = new StringBuilder();

   //     b.Append("<table style='background-color:#f3f3f3; border: #336699 3px solid; ");
   //     b.Append("width:350px; font-size:10pt; font-family:Verdana;' cellspacing='0' cellpadding='3'>");

   //     b.Append("<tr><td colspan='3' style='background-color:#336699; color:white;'>");
   //     b.Append("<b>Employee Details</b>"); b.Append("</td></tr>");
   //     b.Append("<tr><td style='width:80px;'><b>Contact</b></td>");
   //     b.Append("<td style='width:80px;'><b>Email</b></td>");
   //     b.Append("<td><b>Ocheck</b></td></tr>");

   //     b.Append("<tr>");
   //     b.Append("<td>$" + table.Rows[0]["Contact"].ToString() + "</td>");
   //     b.Append("<td>" + table.Rows[0]["Email"].ToString() + "</td>");
   //     b.Append("<td>" + table.Rows[0]["Ocheck"].ToString() + "</td>");
   //     b.Append("</tr>");

   //     b.Append("</table>");
   //     conn.Close();
   //     return b.ToString();
        
   // }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void GridView1_RowCreated(object sender, GridViewRowEventArgs e)
    {
        //if (e.Row.RowType == DataControlRowType.DataRow)
        //{
        //    PopupControlExtender pce = e.Row.FindControl("PopupControlExtender1") as PopupControlExtender;

        //    string behaviorID = "pce_" + e.Row.RowIndex;
        //    pce.BehaviorID = behaviorID;

        //    Image img = (Image)e.Row.FindControl("Image1");

        //    string OnMouseOverScript = string.Format("$find('{0}').showPopup();", behaviorID);
        //    string OnMouseOutScript = string.Format("$find('{0}').hidePopup();", behaviorID);

        //    img.Attributes.Add("onmouseover", OnMouseOverScript);
        //    img.Attributes.Add("onmouseout", OnMouseOutScript);
        //}
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

        //get id from the first and last name combo box
        string checkID = "Select ID from Emp where FName = '" + fname + "' and LName = '" + lname + "'";
        SqlCommand cmd = new SqlCommand(checkID, conn);
        int id = Convert.ToInt32(cmd.ExecuteScalar().ToString());

        SqlCommand checkOrientation = new SqlCommand("Select Ocheck from Emp where ID = '" + id + "'", conn);
        string OCheck = checkOrientation.ExecuteScalar().ToString();

        if (OCheck == "N")
        {
            btnSignIn.Enabled = false;
            //MessageBox.Show("Inform a Facilitator to provide orientation before signing in.",
            //"Orientation Required!",
            //MessageBoxButtons.OK,
            //MessageBoxIcon.Warning
            //);
            AlertWindow.Visible = true;
            AlertWindow.Text = "Inform a Facilitator to provide orientation before signing in.";
            AlertWindow.CssClass = "alert alert-warning";

            

            //EMAIL LOGIC here
            //try
            //{
            //    SmtpClient client = new SmtpClient("smtp.hotmail.com", 25);

            //    client.Credentials = new System.Net.NetworkCredential("pinkevil666@hotmail.com", "Ucan'tCRACKthiS");
            //    client.EnableSsl = true;
            //    client.Port = System.Convert.ToInt32(25);

            //    MailMessage Message = new MailMessage();
            //    Message.From = new MailAddress("fingerprint.attendance.system@gmail.com");
            //    string MailBox = "mikhailshetty@gmail.com";
            //    Message.To.Add(MailBox);

            //    Message.Body = "Waddup bitch";
            //    Message.Subject ="Lafarge Mail test";

            //    client.Send(Message);
            //    client.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }
        else
        {

            //check if already exists -- if yes, then don't sign in again
            SqlCommand checkIfAlreadyExists = new SqlCommand("Select count(*) from TimeLog where ID = '" + id + "' and Date = '" + DateTime.Now + "'", conn);
            int numberOfRowsReturned = Convert.ToInt32(checkIfAlreadyExists.ExecuteScalar().ToString());

            if (numberOfRowsReturned != 1)
            {
                SqlCommand cmdInsert = new SqlCommand("Insert into TimeLog(ID,Date,SignIN) VALUES ('" + Convert.ToString(id) + "','" + DateTime.Now.ToShortDateString() + "','" + DateTime.Now + "')", conn);
                int numberofrows = cmdInsert.ExecuteNonQuery();
            }
        }
        conn.Close();
        GridView1.DataBind();
    }
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Response.Redirect("EditPage.aspx");
    }
    
  
    protected void btnSignOut_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        conn.Open();

        System.Web.UI.WebControls.Button btn = sender as System.Web.UI.WebControls.Button;
        GridViewRow row = btn.NamingContainer as GridViewRow;
        string id = GridView1.DataKeys[row.RowIndex].Values[0].ToString();
        string indexrow = GridView1.DataKeys[row.RowIndex].ToString();
        int index = row.RowIndex;

        SqlCommand cmdIfAlreadySignedOut = new SqlCommand("Select count(*) from TimeLog where Date = '" + DateTime.Now + "' and SignOUT <> '' and ID = '" + id + "'", conn);
        int temp = Convert.ToInt32(cmdIfAlreadySignedOut.ExecuteScalar().ToString());
        System.Web.UI.WebControls.Button btnSignOut1 = (System.Web.UI.WebControls.Button)GridView1.Rows[index].FindControl("btnSignOut");

        if (temp == 1)
        {
            //don't show sign out button
            btnSignOut1.Visible = false;
        }
        else
        {
            SqlCommand cmdInsert = new SqlCommand("Update TimeLog set SignOUT = '" + DateTime.Now + "' where ID ='" + id + "'", conn);
            int numberofrows = cmdInsert.ExecuteNonQuery();

            GridView1.DataBind();
        }      
        // GridView1.Rows[Convert.ToInt32(indexrow)].btnSignOut.disabled;
        conn.Close();
        //btn.Visible = false;
        btnSignOut1.Visible = false;
        
    }
    protected void DropDownListNames_SelectedIndexChanged(object sender, EventArgs e)
    {
        btnSignIn.Enabled = true;
        AlertWindow.Visible = false;
    }


}