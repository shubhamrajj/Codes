<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl2.ascx.cs" Inherits="CachingDemo.WebUserControl2" %>
<%@ OutputCache Duration="10" VaryByParam="None"%>
<asp:Label ID="lblMsg2" runat="server" ForeColor="Blue"></asp:Label>
<p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
</p>
<p>
    &nbsp;</p>

