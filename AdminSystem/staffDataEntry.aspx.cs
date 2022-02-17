using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // Create new instance of clsStaff
        clsStaff staffMember = new clsStaff
        {
            staffFullName = txtStaffFullName.Text,
            staffEmail = txtStaffEmail.Text,
            staffPassword = txtStaffPassword.Text,
            staffSalary = Convert.ToDouble(txtStaffSalary.Text),
            staffDOB = Convert.ToDateTime(txtStaffDOB.Text),
            administrator = txtStaffAdmin.Checked
        };

        Session["staffMember"] = staffMember;

        Response.Redirect("staffViewer.aspx");

        

    
    }

   
}