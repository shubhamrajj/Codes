<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OutputCachingDemo.aspx.cs" Inherits="CachingDemo.Home" %>
<%@ OutputCache Duration="10" VaryByParam="None"  %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-size: 36px">
            <strong>Output Caching Demo</strong></div>
        <asp:Label ID="lblDateTime" runat="server" Font-Bold="True" Font-Size="Medium"></asp:Label>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    </form>
</body>
</html>
