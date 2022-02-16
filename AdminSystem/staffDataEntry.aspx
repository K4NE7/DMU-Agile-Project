<%@ Page Language="C#" AutoEventWireup="true" CodeFile="staffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblStaffFullName" runat="server" Text="Fullname" width="104px"></asp:Label>
            <asp:TextBox ID="txtStaffFullName" runat="server" Height="25px" Width="168px"></asp:TextBox>
        </div>
        
        <div>
            <asp:Label ID="lblStaffEmail" runat="server" Text="Email" width="104px" height="22px"></asp:Label>
            <asp:TextBox ID="txtStaffEmail" runat="server" Height="25px" Width="168px"></asp:TextBox>
        </div>
        
        <div>
            <asp:Label ID="lblStaffPassword" runat="server" Text="Password" width="104px" height="22px"></asp:Label>
            <asp:TextBox ID="txtStaffPassword" runat="server" Height="25px" Width="168px"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="lblStaffDOB" runat="server" Text="Date of Birth" width="104px" height="22px"></asp:Label>
            <asp:TextBox ID="txtStaffDOB" runat="server" Height="25px" Width="168px"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="lblStaffSalary" runat="server" Text="Salary" width="104px" height="22px"></asp:Label>
            <asp:TextBox ID="txtStaffSalary" runat="server" Height="25px" Width="168px"></asp:TextBox>
        </div>

         <div>
              <asp:Label ID="lblStaffAdmin" runat="server" Text="Adminstrator" height="22px" width="104px"></asp:Label>
             <asp:CheckBox ID="txtStaffAdmin" runat="server" Test=""/>
        </div>

        <div>
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>

    </form>
</body>
</html>
