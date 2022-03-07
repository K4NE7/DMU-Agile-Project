<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ordersViewer.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <asp:Label ID="lblOrderID" runat="server" style="z-index: 1; left: 10px; top: 53px; position: absolute" Text="Order number: "></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 10px; position: absolute" Text="Customer Number: "></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 10px; top: 129px; position: absolute" Text="Order date: "></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblKeySent" runat="server" style="z-index: 1; left: 10px; top: 167px; position: absolute" Text="Key sent: "></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblProductID" runat="server" style="z-index: 1; left: 10px; top: 205px; position: absolute" Text="Product ID: "></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 10px; top: 243px; position: absolute" Text="Quantity: "></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblExtraDetails" runat="server" style="z-index: 1; left: 10px; top: 281px; position: absolute" Text="Extra Details: "></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 10px; top: 319px; position: absolute" Text="Edit" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" style="z-index: 1; left: 55px; top: 318px; position: absolute" Text="Delete" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 357px; position: absolute"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
