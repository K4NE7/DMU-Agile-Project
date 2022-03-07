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
        // CustomerID is hardcoded until other group members upload required classes to github
        Session["CustomerID"] = 2;
        txtCustomerID.Text = Session["CustomerID"].ToString();


        DateTime todaysDate = new DateTime();
        todaysDate = DateTime.Now;
        txtOrderDate.Text = todaysDate.ToString("dd.MM.yyyy");


        // Will get from group members class methods later on
        clsDataConnection DB = new clsDataConnection();
        DB.Execute("sproc_tblProduct_SelectAll");
        
        for (int i = 0; i < DB.DataTable.Rows.Count; i++)
        {
            ddProduct.Items.Add(DB.DataTable.Rows[i]["ProductName"].ToString());
            ddProduct.Items[i].Value = DB.DataTable.Rows[i]["ProductID"].ToString();
        }
    }


    protected void btnOk_Click(object sender, EventArgs e)
    {
        if (radioCorrect.Checked == true)
        {
            clsOrders anOrder = new clsOrders();
            anOrder.orderID = 1;
            anOrder.customerID = Int32.Parse(txtCustomerID.Text);
            anOrder.orderDate = DateTime.Now.Date;
            anOrder.keySent = false;
            anOrder.productID = Int32.Parse(ddProduct.SelectedValue);
            anOrder.quantity = Int32.Parse(txtQuantity.Text);
            anOrder.extraDetails = txtExtraDetails.Text;


            Session["anOrder"] = anOrder;
            Response.Redirect("ordersViewer.aspx");
        }
    }
}