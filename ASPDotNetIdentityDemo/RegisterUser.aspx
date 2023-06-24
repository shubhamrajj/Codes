<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterUser.aspx.cs" Inherits="ASPDotNetIdentityDemo.RegisterUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 31px;
            text-align: center;
            background-color: #FF9966;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border="1" style="width: 60%;">
                <tr>
                    <td class="auto-style1" colspan="2">Register User</td>
                </tr>
                <tr>
                    <td>Enter Username :</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Enter Password</td>
                    <td>
                        <asp:TextBox ID="txtPass" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnRegister" runat="server" OnClick="Button1_Click" Text="Register" />
                    </td>
                    <td>
                        <asp:Label ID="lblMsg" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
