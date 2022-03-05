<%@ Page Language="C#" AutoEventWireup="true" CodeFile="staffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstStaffList" runat="server" Height="500px" Width="500px"></asp:ListBox>
            <div>
                <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
                <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />
                <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
            </div>
            <div>
                <asp:Label ID="lblEnterFullName" runat="server" Text="Enter a name"></asp:Label>
                <asp:TextBox ID="txtEnterFullName" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="btnApply" runat="server" Text="Apply" OnClick="btnApply_Click" />
                <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />
            </div>
            <div>
                <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
