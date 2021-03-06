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
        // -1 means that it must be a new record
        Session["staffID"] = -1;
        Response.Redirect("staffDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 staffId;

        // check if user is selected on field then edit
        if (lstStaffList.SelectedIndex != -1)
        {
            staffId = Convert.ToInt32(lstStaffList.SelectedValue);

            Session["staffID"] = staffId;
            Response.Redirect("staffDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 staffId;

        // check if user is selected on a field then delete
        if (lstStaffList.SelectedIndex != -1 )
        {
            staffId = Convert.ToInt32(lstStaffList.SelectedValue);

            Session["staffID"] = staffId;
            Response.Redirect("staffConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    void DisplayStaffMembers()
    {
        clsStaffCollection staffMembers = new clsStaffCollection();
        lstStaffList.DataSource = staffMembers.staffList;

        lstStaffList.DataValueField = "staffID";
        lstStaffList.DataTextField = "staffFullName";

        lstStaffList.DataBind();

    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsStaffCollection clsStaffCollection = new clsStaffCollection();

        // set filter to search for user input
        clsStaffCollection.ReportByFullName(txtEnterFullName.Text);
        lstStaffList.DataSource = clsStaffCollection.staffList;

        lstStaffList.DataValueField = "staffID";
        lstStaffList.DataTextField = "staffFullName";

        lstStaffList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStaffCollection clsStaffCollection = new clsStaffCollection();

        clsStaffCollection.ReportByFullName("");

        // reset filter search to "" (everything)
        txtEnterFullName.Text = "";
        lstStaffList.DataSource = clsStaffCollection.staffList;

        lstStaffList.DataValueField = "staffID";
        lstStaffList.DataTextField = "staffFullName";

        lstStaffList.DataBind();
    }
}