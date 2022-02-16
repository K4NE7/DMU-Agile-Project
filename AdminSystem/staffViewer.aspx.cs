using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStaff staffMember = new clsStaff();

        staffMember = (clsStaff)Session["staffMember"];

        Response.Write(staffMember.staffFullName + "\n");
        Response.Write(staffMember.staffEmail + "\n");
        Response.Write(staffMember.staffPassword + "\n");
        Response.Write(staffMember.staffDOB + "\n");
        Response.Write(staffMember.staffSalary + "\n");
        Response.Write(staffMember.administrator);
    }
}