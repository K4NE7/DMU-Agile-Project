<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ordersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblOrderID" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Order number: " width="111px"></asp:Label>
            <asp:TextBox ID="txtOrderID" runat="server" style="z-index: 1; left: 122px; top: 15px; position: absolute" width="128px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 10px; top: 53px; position: absolute" Text="Customer number: "></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 10px; top: 91px; position: absolute" Text="Order date: " width="111px"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="txtOrderDate" runat="server" style="z-index: 1; left: 122px; top: 88px; position: absolute" width="128px"></asp:TextBox>
            <asp:Label ID="lblKeySent" runat="server" style="z-index: 1; left: 10px; top: 129px; position: absolute" Text="Key sent: " width="111px"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="txtKeySent" runat="server" style="z-index: 1; left: 122px; top: 124px; position: absolute" width="128px"></asp:TextBox>
            <asp:Label ID="lblProductID" runat="server" style="z-index: 1; left: 10px; top: 165px; position: absolute" Text="Product ID: " width="111px"></asp:Label>
            <br />
            <asp:TextBox ID="txtProductID" runat="server" style="z-index: 1; left: 122px; top: 162px; position: absolute" width="128px"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtQuantity" runat="server" style="z-index: 1; left: 122px; top: 203px; position: absolute" width="128px"></asp:TextBox>
            <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 10px; top: 205px; position: absolute" Text="Quantity: " width="111px"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblExtraDetails" runat="server" style="z-index: 1; left: 10px; top: 243px; position: absolute" Text="Extra details: " width="111px"></asp:Label>
            <asp:TextBox ID="txtExtraDetails" runat="server" style="z-index: 1; left: 122px; top: 242px; position: absolute" width="128px"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 10px; top: 281px; position: absolute" Text="Active" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 319px; position: absolute"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 10px; top: 357px; position: absolute" Text="Ok" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 58px; top: 357px; position: absolute" Text="Cancel" />
            <br />
            <br />
            <br />
        </div>
        <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 122px; top: 51px; position: absolute" width="128px"></asp:TextBox>
    </form>
</body>
</html>
