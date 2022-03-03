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
            staffMember.staffFullName = staffFullName;
            staffMember.staffEmail = staffEmail;
            staffMember.staffPassword = staffPassword;
            staffMember.staffDOB = Convert.ToDateTime(staffDOB);
            staffMember.staffSalary = Convert.ToDouble(staffSalary);
            staffMember.administrator = administrator;

            Session["staffMember"] = staffMember;
            Response.Redirect("staffViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
       

        

    
    }

   
}