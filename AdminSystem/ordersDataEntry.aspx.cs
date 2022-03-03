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

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsOrders anOrder = new clsOrders();
        anOrder.orderID = Convert.ToInt32(txtOrderID.Text);
        Session["anOrder"] = anOrder;
        Response.Redirect("ordersViewer.aspx");
    }
}