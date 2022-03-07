<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ordersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

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
            <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 10px; top: 53px; position: absolute; right: 1740px" Text="Customer: "></asp:Label>
            <br />
            <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 100px; top: 52px; position: absolute; margin-top: 0px;" ReadOnly="True"></asp:TextBox>
            <br />
            <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 10px; top: 91px; position: absolute" Text="Order Date: " height="19px" width="96px"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="txtOrderDate" runat="server" style="z-index: 1; left: 100px; top: 91px; position: absolute" ReadOnly="True" TextMode="DateTime"></asp:TextBox>
            <asp:Label ID="lblKeySent" runat="server" style="z-index: 1; left: 10px; top: 129px; position: absolute" Text="Key sent: " height="19px" width="96px"></asp:Label>
            <br />
            <asp:TextBox ID="txtKeySent" runat="server" ReadOnly="True" style="z-index: 1; left: 100px; top: 130px; position: absolute">False</asp:TextBox>
            <br />
            <asp:RadioButton ID="radioCorrect" runat="server" style="z-index: 1; left: 10px; top: 167px; position: absolute" Text="Is above info correct?" TextAlign="Left" />
            <br />
            <br />
            <br />
            <asp:Label ID="lblProductID" runat="server" style="z-index: 1; left: 10px; top: 224px; position: absolute" Text="Product: " height="19px" width="96px"></asp:Label>
            <br />
            <asp:DropDownList ID="ddProduct" runat="server" style="z-index: 1; left: 100px; top: 221px; position: absolute; bottom: 703px;">
            </asp:DropDownList>
            <br />
            <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 10px; top: 262px; position: absolute" Text="Quantity: " height="19px" width="96px"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="txtQuantity" runat="server" style="z-index: 1; left: 100px; top: 261px; position: absolute; width: 41px;" TextMode="Number">1</asp:TextBox>
            <asp:Label ID="lblExtraDetails" runat="server" height="19px" style="z-index: 1; left: 10px; top: 300px; position: absolute" Text="ExtraDetails: " width="96px"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="txtExtraDetails" runat="server" style="z-index: 1; left: 100px; top: 280px; position: absolute; margin-top: 16px"></asp:TextBox>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 338px; position: absolute"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 10px; top: 376px; position: absolute" Text="Ok" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" style="z-index: 1; left: 62px; top: 376px; position: absolute" Text="Cancel" />
            <br />
            <br />
            <br />
            <br />

        </div>
    </form>
</body>
</html>
