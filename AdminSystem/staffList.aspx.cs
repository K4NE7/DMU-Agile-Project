using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // check if first time page is displayed
        if (IsPostBack == false)
        {
            DisplayStaffMembers();
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["staffID"] = -1;
        Response.Redirect("staffDataEntry.aspx");
    }

    void DisplayStaffMembers()
    {
        clsStaffCollection staffMembers = new clsStaffCollection();
        lstStaffList.DataSource = staffMembers.staffList;

        lstStaffList.DataValueField = "staffID";
        lstStaffList.DataTextField = "staffFullName";

        lstStaffList.DataBind();

    }
}