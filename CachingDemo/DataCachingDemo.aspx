<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataCachingDemo.aspx.cs" Inherits="CachingDemo.DataCachingDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
        .auto-style2 {
            font-size: medium;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>Data Caching Demo<br />
            <br />
            <asp:Label ID="lblMsg" runat="server" CssClass="auto-style2"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            </strong>
        </div>
    </form>
</body>
</html>
