<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FragmentCachingDemo.aspx.cs" Inherits="CachingDemo.FragmentCachingDemo" %>

<%@ Register src="WebUserControl1.ascx" tagname="WebUserControl1" tagprefix="uc1" %>
<%@ Register src="WebUserControl2.ascx" tagname="WebUserControl2" tagprefix="uc2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <strong style="font-size: x-large">Fragment Caching Demo</strong></div>
        <uc1:WebUserControl1 ID="WebUserControl11" runat="server" />
        <uc2:WebUserControl2 ID="WebUserControl21" runat="server" />
    </form>
</body>
</html>
