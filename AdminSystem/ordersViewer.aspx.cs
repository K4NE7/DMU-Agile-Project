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
        clsOrders anOrder = new clsOrders();
        anOrder = (clsOrders)Session["anOrder"];
      
        /* Response.Write(anOrder.orderID);
        Response.Write("\n" + anOrder.customerID);
        Response.Write("\n" + anOrder.orderDate);
        Response.Write("\n" + anOrder.keySent);
        Response.Write("\n" + anOrder.productID);
        Response.Write("\n" + anOrder.quantity);
        Response.Write("\n" + anOrder.extraDetails);*/

        lblOrderID.Text += anOrder.orderID;
        lblCustomerID.Text += anOrder.customerID;
        lblOrderDate.Text += anOrder.orderDate.Date;
        lblKeySent.Text += anOrder.keySent;
        lblProductID.Text += anOrder.productID;
        lblQuantity.Text += anOrder.quantity;
        lblExtraDetails.Text += anOrder.extraDetails;
    }
}