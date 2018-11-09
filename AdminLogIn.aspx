<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogIn.aspx.cs" Inherits="SVARD_Shopping.AdminLogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            margin-left: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p class="auto-style1">
            <asp:Label ID="Label2" runat="server" BackColor="#CCCCCC" Font-Bold="True" Font-Size="XX-Large" ForeColor="Maroon" Text="SVARD ADMIN"></asp:Label>
        </p>
        <p class="auto-style1">
            LOGIN</p>
        <p class="auto-style1">
            <asp:Label ID="Label4" runat="server" Text="Username"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            :<asp:TextBox ID="TextBox2" runat="server" Height="17px" Width="208px"></asp:TextBox>
        </p>
        <p class="auto-style1">
            <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            :<asp:TextBox ID="TextBox3" runat="server" Height="16px" TextMode="Password" Width="209px"></asp:TextBox>
        </p>
        <p class="auto-style1">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </p>
        <p class="auto-style1">
            <asp:Button ID="Button3" runat="server" CssClass="auto-style2" Height="25px" OnClick="Button3_Click" OnClientClick="~/AddProduct.aspx" Text="LOG IN" Width="113px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" Height="25px" OnClick="Button4_Click" Text="Back" Width="111px" />
        </p>
        <p class="auto-style1">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </p>
        <p class="auto-style1">
            &nbsp;</p>
        <p class="auto-style1">
            &nbsp;</p>
        <p class="auto-style1">
            &nbsp;</p>
    </form>
</body>
</html>
