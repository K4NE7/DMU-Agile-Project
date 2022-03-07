using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 staffId;
    protected void Page_Load(object sender, EventArgs e)
    {
        staffId = Convert.ToInt32(Session["staffID"]);
        lblDeleteMessage.Text = "Are you sure you want to delete " + staffId;
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsStaffCollection clsStaffCollection = new clsStaffCollection();
        clsStaffCollection.ThisStaffMember.Find(staffId);
        
        clsStaffCollection.Delete();
        
        Response.Redirect("staffList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("staffList.aspx");
    }
}