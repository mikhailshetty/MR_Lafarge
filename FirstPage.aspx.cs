using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using AjaxControlToolkit;
using System.Text;
public partial class FirstPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void Circle1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("LoginPage.aspx");
    }
    protected void Circle2_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("FacilitatorApproval.aspx");
    }
    protected void Circle3_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("EditPage.aspx");
    }
}