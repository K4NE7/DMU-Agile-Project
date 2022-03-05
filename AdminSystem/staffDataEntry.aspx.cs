using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 staffId;

    protected void Page_Load(object sender, EventArgs e)
    {
        staffId = Convert.ToInt32(Session["staffID"]);

        if (IsPostBack == false)
        {
            if (staffId != -1)
            {
                DisplayStaff();
            }
        }
    }
    
    void DisplayStaff()
    {
        clsStaffCollection clsStaffCollection = new clsStaffCollection();

        // collect previous fields from list
        clsStaffCollection.ThisStaffMember.Find(staffId);
        txtStaffFullName.Text = clsStaffCollection.ThisStaffMember.staffFullName;
        txtStaffEmail.Text = clsStaffCollection.ThisStaffMember.staffEmail;
        txtStaffPassword.Text = clsStaffCollection.ThisStaffMember.staffPassword;
        txtStaffDOB.Text = clsStaffCollection.ThisStaffMember.staffDOB.ToString();
        txtStaffSalary.Text = clsStaffCollection.ThisStaffMember.staffSalary.ToString();
        txtStaffAdmin.Text = clsStaffCollection.ThisStaffMember.administrator.ToString();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStaff staffMember = new clsStaff();

        // collect all fields
        string staffFullName = txtStaffFullName.Text;
        string staffEmail = txtStaffEmail.Text;
        string staffPassword = txtStaffPassword.Text;
        string staffDOB = txtStaffDOB.Text;
        string staffSalary = txtStaffSalary.Text;
        bool administrator = txtStaffAdmin.Checked;

        String Error = "";
        Error = staffMember.Valid(staffFullName, staffEmail, staffPassword, staffDOB, staffSalary);
        
        // Ensure it passes all validation, if passes redirects else provides error message(s)
        if (Error == "")
        {
            // store fields
            staffMember.staffId = staffId;
            staffMember.staffFullName = staffFullName;
            staffMember.staffEmail = staffEmail;
            staffMember.staffPassword = staffPassword;
            staffMember.staffDOB = Convert.ToDateTime(staffDOB);
            staffMember.staffSalary = Convert.ToDouble(staffSalary);
            staffMember.administrator = administrator;

            clsStaffCollection staffList = new clsStaffCollection();
            
            // check if new record or editing existing record
            if (staffId == -1)
            {
                staffList.ThisStaffMember = staffMember;
                staffList.Add();
            }
            else
            {
                staffList.ThisStaffMember.Find(staffId);
                staffList.ThisStaffMember = staffMember;
                staffList.Update();
            }

            Response.Redirect("staffList.aspx");
        }
        else
        {
            lblError.Text = Error;
            Error = "";
        }
    
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("staffList.aspx");
    }
}