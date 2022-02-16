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
        clsStaff staffMember = new clsStaff();

        staffMember.staffFullName = txtStaffFullName.Text;
        staffMember.staffEmail = txtStaffEmail.Text;
        staffMember.staffPassword = txtStaffPassword.Text;
        staffMember.staffSalary = Convert.ToDouble(txtStaffSalary.Text);
        staffMember.staffDOB = Convert.ToDateTime(txtStaffDOB.Text);
        staffMember.administrator = txtStaffAdmin.Checked;

        Session["staffMember"] = staffMember;

        Response.Redirect("staffViewer.aspx");

        

    
    }

   
}